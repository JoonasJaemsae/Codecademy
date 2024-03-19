def summa():
    yield 'Summa Cum Laude'
def magna():
    yield 'Magna Cum Laude' 
def cum_laude():
    yield 'Cum Laude'
# Write your code below:
def graduation_countdown(days):
  while days >= 0:
    days_left = yield days
    if days_left is not None:
      days = days_left
    else:
      days -= 1

days = 25
countdown_generator = (day for day in range(days, -1, -1))

grad_days = graduation_countdown(days)
for day in grad_days:
  if day == 15:
    grad_days.send(10)
  elif day == 3:
    grad_days.close()
  print("Days Left: {}".format(day))

gpas = [3.2, 4.0, 3.6, 2.9]
