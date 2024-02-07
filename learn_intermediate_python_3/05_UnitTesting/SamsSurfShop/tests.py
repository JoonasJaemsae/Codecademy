# Write your code below:
import surfshop
import unittest

class TestSurfshop(unittest.TestCase):
    pass

    def setUp(self):
      self.cart = surfshop.ShoppingCart()

    def test_add_surfboards(self):
      self.assertEqual(self.cart.add_surfboards(1), 'Successfully added 1 surfboard to cart!')

unittest.main()