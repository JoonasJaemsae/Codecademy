class FishInventory:
  def __init__(self, fishList):
      self.available_fish = fishList

fish_inventory_cls = FishInventory(["Bubbles", "Finley", "Moby"])

# Write your code below:
# Expected failure: prints TypeError: 'FishInventory' object is not iterable.
# iter() and next() have not been defined in the class.
for fish in fish_inventory_cls:
  print(fish)