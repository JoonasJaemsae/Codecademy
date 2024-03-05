import pandas as pd

visits = pd.read_csv('visits.csv',
                     parse_dates=[1])
cart = pd.read_csv('cart.csv',
                   parse_dates=[1])
checkout = pd.read_csv('checkout.csv',
                       parse_dates=[1])
purchase = pd.read_csv('purchase.csv',
                       parse_dates=[1])

# print(visits.head(10))
# print(cart.head(10))
# print(checkout.head(10))
# print(purchase.head(10))

# Dedup all the dfs
visits = visits.drop_duplicates(subset='user_id')
cart = cart.drop_duplicates(subset='user_id')
checkout = checkout.drop_duplicates(subset='user_id')
purchase = purchase.drop_duplicates(subset='user_id')

# Task 5
visits_carts = pd.merge(visits, cart, how='left')
visits_carts['put_items_to_cart'] = pd.notnull(visits_carts["cart_time"])
print(visits_carts)
visits_carts = visits_carts.groupby('put_items_to_cart').user_id.count().reset_index()
visits_carts = visits_carts.rename(columns={"user_id": "count"})
visits_carts["percentage"] = visits_carts["count"] / float(visits_carts["count"].sum()) * 100
print(visits_carts)

# Task 6
carts_checkouts = pd.merge(cart, checkout, how='left')
carts_checkouts['proceeded_to_checkout'] = pd.notnull(carts_checkouts["checkout_time"])
carts_checkouts = carts_checkouts.groupby('proceeded_to_checkout').user_id.count().reset_index()
carts_checkouts = carts_checkouts.rename(columns={"user_id": "count"})
carts_checkouts["percentage"] = carts_checkouts["count"] / float(carts_checkouts["count"].sum()) * 100
print(carts_checkouts)

# Task 7
all_data = visits.merge(cart, how='left')\
.merge(checkout, how='left')\
.merge(purchase, how='left')

print(all_data.head(20))

# Task 8
# Filter rows where checkout_time is not NaT
chouts_purchases = all_data.dropna(subset=['checkout_time'])
chouts_purchases["made_a_purchase"] = chouts_purchases["purchase_time"].notnull()
chouts_purchases = chouts_purchases.groupby('made_a_purchase').user_id.count().reset_index()
chouts_purchases = chouts_purchases.rename(columns={"user_id": "count"})
chouts_purchases["percentage"] = chouts_purchases["count"] / float(chouts_purchases["count"].sum()) * 100
print(chouts_purchases)

# Task 10
all_data["total_time"] = all_data["purchase_time"] - all_data["visit_time"]
print(all_data["total_time"])
print('Average time to purchase: ', all_data["total_time"].mean())
