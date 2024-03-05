import pandas as pd

ad_clicks = pd.read_csv('ad_clicks.csv')

grouped_by_source = ad_clicks.groupby('utm_source').user_id.count().reset_index()

print(grouped_by_source)

ad_clicks['is_click'] = ad_clicks.ad_click_timestamp.notnull()

print(ad_clicks.head(10))

clicks_by_source = ad_clicks.groupby(['utm_source', 'is_click']).user_id.count().reset_index()

print(clicks_by_source)

clicks_pivot = clicks_by_source.pivot(
  columns = 'is_click',
  index = 'utm_source',
  values = 'user_id'
).reset_index()

clicks_pivot['percent_clicked'] = clicks_pivot[True] / (clicks_pivot[True] + clicks_pivot[False])

print(clicks_pivot)

# Step 7
ex_counts = ad_clicks.groupby('experimental_group').user_id.count().reset_index()

# print(ex_counts)

ex_clicks = ad_clicks \
  .groupby(['experimental_group', 'is_click']) \
  .user_id \
  .count() \
  .reset_index() \
  .pivot(
    columns = 'is_click',
    index = 'experimental_group',
    values = 'user_id'
  ).reset_index()

ex_clicks['percent_clicked'] = ex_clicks[True] / (ex_clicks[True] + ex_clicks[False])

print(ex_clicks)

# Choose rows where the experimental group is A.
a_clicks = ad_clicks[ad_clicks.experimental_group == 'A']
a_clicks_pivot = a_clicks.groupby(['day', 'is_click']).user_id.count().reset_index().pivot(
    columns = 'is_click',
    index = 'day',
    values = 'user_id'
  ).reset_index()

a_clicks_pivot['percent_clicked'] = a_clicks_pivot[True] / (a_clicks_pivot[True] + a_clicks_pivot[False])

b_clicks = ad_clicks[ad_clicks.experimental_group == 'B']
b_clicks_pivot = b_clicks.groupby(['day', 'is_click']).user_id.count().reset_index().pivot(
    columns = 'is_click',
    index = 'day',
    values = 'user_id'
  ).reset_index()

b_clicks_pivot['percent_clicked'] = b_clicks_pivot[True] / (b_clicks_pivot[True] + b_clicks_pivot[False])

print(a_clicks_pivot)
print(b_clicks_pivot)
