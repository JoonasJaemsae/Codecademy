long_list = [1, 5, 6, 7, -23, 69.5, True, "very", "long", "list", "that", "keeps", "going.", "Let's", "practice", "getting", "the", "length"]

big_range = range(2, 3000, 100)

# Your code below: 
long_list_len = len(long_list)
print(long_list_len)
# Ranges don't need to be converted to list to take their len
big_range_length = len(big_range)
print(big_range_length)
