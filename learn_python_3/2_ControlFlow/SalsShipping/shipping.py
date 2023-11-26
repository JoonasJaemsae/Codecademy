weight = 4.8
premium = True
premium_cost = 125.00
print("Cost of premium: " + str(premium_cost))

# Ground Shipping
if weight <= 2:
  costs = weight * 1.50 + 20.00
elif 2 < weight <= 6:
  costs = weight * 3.00 + 20.00
elif 6 < weight <= 10:
  costs = weight * 4.00 + 20.00
elif weight > 10:
  costs = weight * 4.75 + 20.00
print("Cost of ground shipping: " + str(costs))

# Drone shipping
if weight <= 2:
  costs = weight * 4.50
elif 2 < weight <= 6:
  costs = weight * 9.00
elif 6 < weight <= 10:
  costs = weight * 12.00
elif weight > 10:
  costs = weight * 14.25
print("Cost of drone shipping: " + str(costs))