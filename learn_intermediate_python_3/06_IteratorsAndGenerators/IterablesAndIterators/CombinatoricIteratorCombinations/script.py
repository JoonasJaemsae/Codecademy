import itertools

collars = ["Red-S","Red-M", "Blue-XS", "Green-L", "Green-XL", "Yellow-M"]

# Write your code below: 
collar_combo_iterator = itertools.combinations(collars, 3)

for combo in collar_combo_iterator:
  print(combo)