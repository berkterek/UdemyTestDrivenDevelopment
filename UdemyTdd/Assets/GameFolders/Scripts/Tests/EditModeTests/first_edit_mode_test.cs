using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace EditModeTests.BasicTests
{
    public class first_edit_mode_test
    {
        [Test]
        public void two_plus_two_equal_to_four()
        {
            int number1 = 2;
            int number2 = 2;

            int result = number1 + number2;
            
            Assert.AreEqual(4,result);
        }

        [Test]
        public void string_value_result_equal_to_udemy()
        {
            string value = "Udemy";
            
            Assert.AreEqual("Udemy",value);
        }

        [Test]
        public void list_string_values_count_equal_to_10()
        {
            List<string> values = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                values.Add("Udemy");
            }
            
            Assert.AreEqual(10,values.Count);
        }

        [Test]
        public void string_value_not_equal_to_udemy()
        {
            string value = "Berk";
            
            Assert.AreNotEqual("Udemy",value);
        }

        [Test]
        public void int_value_less_than_10()
        {
            int value = 1;
            
            Assert.Less(value,10);
        }
        
        [Test]
        public void int_value_greater_than_10()
        {
            int value = 15;
            
            Assert.Greater(value,10);
        }
        
        [Test]
        public void list_values_expected_to_null()
        {
            List<string> values = null;
            
            Assert.Null(values);
        }
    }    
}