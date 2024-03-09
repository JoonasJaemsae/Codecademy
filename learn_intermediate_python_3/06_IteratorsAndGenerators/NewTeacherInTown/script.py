from roster import student_roster

student_roster_iterator = iter(student_roster)

i = 0
while i in range(0, 10):
  print(next(student_roster_iterator))
  i = i + 1
