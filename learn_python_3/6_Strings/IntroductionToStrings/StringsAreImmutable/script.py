first_name = "Bob"
last_name = "Daily"

# The below won't work
# first_name[0] = "R"

fixed_first_name = "R" + first_name[len(first_name)-2:]
print(fixed_first_name)