# Same output of 226 after dedupping cart
# value = set(cart["user_id"]).intersection(set(checkout["user_id"]))
# print(f" Intersection of cart and checkout: {len(value)}")

# Dedup checkout
# print('---checkouts---')
# print(checkout)
# checkout = checkout.drop_duplicates(subset='user_id')
# print(checkout)
# print('---checkouts---')

# Assuming your DataFrame is named df

# Filter rows where checkout_time is not NaT
checkout_users = all_data.dropna(subset=['checkout_time'])

# Count the number of users who have both checkout_time and purchase_time
purchase_count = checkout_users['purchase_time'].notna().sum()

# Total number of users with checkout_time
total_checkout_users = len(checkout_users)

# Count the number of users who have checkout_time but no purchase_time
no_purchase_count = total_checkout_users - purchase_count

# Calculate the percentages
percentage_with_purchase = (purchase_count / total_checkout_users) * 100
percentage_no_purchase = (no_purchase_count / total_checkout_users) * 100

# Create a DataFrame to store the results
results_df = pd.DataFrame({
    'Metric': ['Percentage of users with purchase_time among those with checkout_time', 
               'Percentage of users without purchase_time among those with checkout_time'],
    'Value': [percentage_with_purchase, percentage_no_purchase]
})

# Display the results DataFrame
print(results_df)

# Task 8 alternative
# Filter rows where checkout_time is not NaT
chouts_purchases = all_data.dropna(subset=['checkout_time'])
# chouts_purchases = chouts_purchases[["user_id", "checkout_time", "purchase_time"]]
chouts_purchases["made_a_purchase"] = chouts_purchases["purchase_time"].notnull()
chouts_purchases = chouts_purchases.groupby('made_a_purchase').user_id.count().reset_index()
chouts_purchases = chouts_purchases.rename(columns={"user_id": "count"})
chouts_purchases["percentage"] = chouts_purchases["count"] / float(chouts_purchases["count"].sum()) * 100
print(chouts_purchases)

# # print('nunique: ', all_data.nunique())
# # all_data["visited_the_site"] = pd.notnull(all_data["visit_time"])
# # all_data["put_items_to_cart"] = pd.notnull(all_data["cart_time"])
# all_data["proceeded_to_checkout"] = pd.notnull(all_data["checkout_time"])
# all_data["made_a_purchase"] = pd.notnull(all_data["purchase_time"])
# task8_data = all_data.groupby(["proceeded_to_checkout", "made_a_purchase"]).user_id.count().reset_index()
# task8_data = task8_data.rename(columns={"user_id": "count"})
# task8_data["overall_percentage"] = task8_data["count"] / float(task8_data["count"].sum()) * 100
# print(task8_data)

# # Task 8: Percentage of users proceeding to checkout but no purchasing
# checkout_but_no_purchase = task8_data.at[2, 'count'] / float(task8_data.at[1, 'count'] + task8_data.at[2, 'count']) * 100
# print(checkout_but_no_purchase)

# #####################
checkout_df = all_data[["checkout_time", "purchase_time"]].dropna(how="all")
print(f"checkout dataframe is {checkout_df}")
checkout_df["is_checkout"] = checkout_df["checkout_time"].notnull()
checkout_df["is_purchase"] = checkout_df["purchase_time"].notnull() 
total_checkout = sum(checkout_df["is_checkout"])
print(checkout_df[["is_checkout", "is_purchase"]].groupby(["is_checkout", "is_purchase"]).size()/total_checkout)

