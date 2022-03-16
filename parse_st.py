import  pandas as pd
import mt940

import pyodbc

def pass_to_db():
    details = dict()
    details['server'] = 'luko-melo99.database.windows.net'
    details['database'] = 'MT_CUSTOMER_DATA'
    details['username'] = 'team_admin'
    details['password'] = 'salmar#22'

    return details


mt940.tags.BalanceBase.scope = mt940.models.Transaction
transactions = mt940.models.Transactions(processors=dict(
       pre_statement=[
           mt940.processors.add_currency_pre_processor(' '),
       ],
   ))

with open('mt_940.txt',"r") as f:
    data = f.read()

transactions.parse(data)
transaction_data_one_set = dict()

count = 0
for transaction in transactions:
    complete_info=list(transaction.data.keys())
    count += 1
    if 'status' in complete_info:
        if transaction.data['status'] == 'D':
            transaction.data['status'] = 'Debit'
        if transaction.data['status'] == 'C':
            transaction.data['status'] = 'Credit'
    for i in complete_info:
        transaction.data[i] = str(transaction.data[i])
    transaction_data_one_set[count] = transaction.data

df = pd.DataFrame(transaction_data_one_set)
df = df.transpose()
df.fillna('Currently Not Applicable', inplace=True)
del transaction_data_one_set
      
col_names = list(df.columns)
for i in col_names:
    if i.find('_') != -1:
        col_names[col_names.index(i)]=i.replace('_',' ')


df.columns = col_names

#db_login = pass_to_db()

#cnxn = pyodbc.connect('DRIVER={SQL Server};SERVER='+db_login['server']+';DATABASE='+db_login['database']+';UID='+db_login['username']+';PWD='+ db_login['password'])
#cursor = cnxn.cursor()

## Inserting  Dataframe into SQL Server:
##for index, row in df.iterrows():
#    cursor.execute("INSERT INTO mt_parsed_data  values(?,?,?,?,?,?,?,?,?,?,?,?,?,?)",row['status'],row['funds code'],row['amount'],row['id'],row['customer reference'],row['bank reference'],row['extra details'],row['currency'],row['date'],row['entry date'],row['guessed entry date'],row['transaction details'],row['final closing balance'],row['available balance'])
   
#cnxn.commit()
#cursor.close()
#cnxn.close()


del count
del col_names


df.to_csv('mt_in_csv.csv',index=False)

del[df]

