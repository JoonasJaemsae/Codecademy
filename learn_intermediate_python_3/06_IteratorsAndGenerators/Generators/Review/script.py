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

gpas = [3.2, 4.0, 3.6, 2.9]
