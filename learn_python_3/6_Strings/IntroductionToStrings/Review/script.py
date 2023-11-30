first_name = "Joey"
last_name = "Armadillo"

def username_generator(first_name, last_name):
  user_name = first_name[:3] + last_name[:4]
  return user_name

def password_generator(user_name):
  password = ""
  for index in range(0, len(user_name)):
    password += (user_name[index - 1])
  return password

user_name = username_generator(first_name, last_name)
pw = password_generator(user_name)
print(user_name)
print(pw)