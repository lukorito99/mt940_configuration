import pandas as pd

df = pd.read_csv('mt_with_possible_changes.csv')


df = df.apply(lambda z: pd.Series(z.dropna().values))

df.fillna(' ', inplace=True)


x = df.to_html()

with open ('data_frame_in_html.html',"w") as ht:
    ht.write(x)

del [df]