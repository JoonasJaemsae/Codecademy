customer_rewards = {
  'Zoltan': 82570,
  'Guadalupe': 29850,
  'Mario': 17849
}

def display_rewards_account(customer):
  # Write your code below:
  try:
    rewards_number = customer_rewards[customer]
  except KeyError:
    print('Customer was not found in rewards program!')
  else:
    print('Rewards account number is: ' + str(rewards_number))

# Change customer to 'Mario' to test the else clause
customer = 'Zuigly'
display_rewards_account(customer)
