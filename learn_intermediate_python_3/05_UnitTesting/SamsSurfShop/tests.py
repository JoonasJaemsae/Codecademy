# Write your code below:
import surfshop
import unittest

class TestSurfshop(unittest.TestCase):

    def setUp(self):
      self.cart = surfshop.ShoppingCart()

    def test_add_surfboards(self):
      self.assertEqual(self.cart.add_surfboards(1), 'Successfully added 1 surfboard to cart!')

    def test_add_surfboards_2(self):
      self.assertEqual(self.cart.add_surfboards(2), 'Successfully added 2 surfboards to cart!')

    def test_add_surfboards_5(self):
      self.assertRaises(surfshop.TooManyBoardsError, self.cart.add_surfboards, 5)

    @unittest.expectedFailure
    def test_apply_locals_discount(self):
      self.cart.apply_locals_discount()
      self.assertTrue(self.cart.locals_discount, True)
      
unittest.main()