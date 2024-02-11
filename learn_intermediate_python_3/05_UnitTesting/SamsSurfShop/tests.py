# Write your code below:
import surfshop
import unittest

class TestSurfshop(unittest.TestCase):

    def setUp(self):
      self.cart = surfshop.ShoppingCart()

    def test_add_surfboards(self):
      for i in range(2, 5):
        with self.subTest("value: ", i=i):
          self.assertEqual(self.cart.add_surfboards(i), f'Successfully added {i} surfboards to cart!')
        # Initialize shopping cart after every iteration to reset surfboard amount to 0.
        self.cart = surfshop.ShoppingCart()

    @unittest.skip("Off-season. No need to limit boards.")
    def test_add_surfboards_5(self):
      self.assertRaises(surfshop.TooManyBoardsError, self.cart.add_surfboards, 5)

    # @unittest.expectedFailure
    def test_apply_locals_discount(self):
      self.cart.apply_locals_discount()
      self.assertTrue(self.cart.locals_discount, True)
      
unittest.main()