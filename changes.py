import pandas as pd

df = pd.read_csv('mt_with_possible_changes.csv')

df.fillna(' ', inplace=True)
df = df.apply(lambda g: pd.Series(g.dropna().values))

x = df.to_html()

with open ('data_frame_in_html.html',"w") as ht:
    ht.write(x)

del [df]