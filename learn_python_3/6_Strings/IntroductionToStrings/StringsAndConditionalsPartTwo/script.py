word1 = "watermelon"
word2 = "melon"
word3 = "berry"
word4 = "manhattan"
word5 = "san francisco"

def contains(big_string, little_string):
  return little_string in big_string

print(contains(word1, word2))
print(contains(word1, word3))

# Finds commo, uniqu letters in two words
def common_letters(string_one, string_two):
  letter_list = []
  for character in string_one:
    if character in string_two and not character in letter_list:
      letter_list.append(character)
      continue
  return letter_list

print(common_letters(word1, word2))
print(common_letters(word4, word5))