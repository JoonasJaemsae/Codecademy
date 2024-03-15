def cs_generator():
  for i in range(1,5):
    yield "Computer Science " + str(i)

# Write your code below:
cs_courses = cs_generator()
for course in cs_courses:
  print(course)

print('')
cs_generator_exp = ("Computer Science {}".format(i) for i in range(1,5))
for course in cs_generator_exp:
  print(course)
