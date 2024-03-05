import pandas as pd

orders = pd.read_csv('orders.csv')

shoe_counts = orders.groupby(['shoe_type', 'shoe_color']).id.count().reset_index()

shoe_counts = shoe_counts.rename(columns={"id": "counts"})

print(shoe_counts)
