using NUnit.Framework;
using UdemyTdd.ScriptableObjects;
using UnityEngine;

namespace EditModeTests.Players.Stats
{
    public class player_level_process
    {
        CharacterStatsSO GetStats()
        {
            return ScriptableObject.CreateInstance<CharacterStatsSO>();
        }

        [Test]
        public void set_five_experience_point_result_returns_five()
        {
            var stats = GetStats();

            int expectedResult = 5;

            stats.SetExperiencePoint(expectedResult);

            Assert.AreEqual(expectedResult, stats.CurrentExperience);
        }

        [Test]
        public void set_max_experience_minus_one_point_result_same()
        {
            var stats = GetStats();

            int expectedResult = stats.MaxExperience - 1;

            stats.SetExperiencePoint(expectedResult);

            Assert.AreEqual(expectedResult, stats.CurrentExperience);
        }

        [Test]
        public void set_max_experience_point_current_experience_point_result_zero()
        {
            var stats = GetStats();

            int expectedResult = 0;

            stats.SetExperiencePoint(stats.MaxExperience);

            Assert.AreEqual(expectedResult, stats.CurrentExperience);
        }

        [Test]
        public void set_max_experience_point_level_result_returns_current_level_plus_one()
        {
            var stats = GetStats();

            int expectedResult = stats.Level + 1;

            stats.SetExperiencePoint(stats.MaxExperience);

            Assert.AreEqual(expectedResult, stats.Level);
        }

        [Test]
        public void set_max_experience_point_max_point_result_increase()
        {
            var stats = GetStats();

            int expectedResult = Mathf.FloorToInt(stats.MaxExperience * stats.IncreaseExperienceValue);

            stats.SetExperiencePoint(stats.MaxExperience);

            Assert.AreEqual(expectedResult, stats.MaxExperience);
        }

        [Test]
        public void set_max_experience_plus_one_current_experience_result_one()
        {
            var stats = GetStats();

            int expectedResult = 1;

            stats.SetExperiencePoint(stats.MaxExperience + expectedResult);

            Assert.AreEqual(expectedResult, stats.CurrentExperience);
        }

        [Test]
        public void set_max_experience_plus_two_current_experience_result_two()
        {
            var stats = GetStats();

            int expectedResult = 2;

            stats.SetExperiencePoint(stats.MaxExperience + expectedResult);

            Assert.AreEqual(expectedResult, stats.CurrentExperience);
        }

        [Test]
        public void set_max_experience_plus_four_current_experience_result_four()
        {
            var stats = GetStats();

            int expectedResult = 4;

            stats.SetExperiencePoint(stats.MaxExperience + expectedResult);

            Assert.AreEqual(expectedResult, stats.CurrentExperience);
        }

        [Test]
        public void set_max_experience_plus_one_two_time_current_level_returns_plus_two()
        {
            var stats = GetStats();

            int loopCount = 2;
            int expectedResult = stats.Level + loopCount;

            for (int i = 0; i < loopCount; i++)
            {
                stats.SetExperiencePoint(stats.MaxExperience + 1);
            }

            Assert.AreEqual(expectedResult, stats.Level);
        }

        [Test]
        public void set_max_experience_plus_one_five_time_current_level_returns_plus_five()
        {
            var stats = GetStats();

            int loopCount = 5;
            int expectedResult = stats.Level + loopCount;

            for (int i = 0; i < loopCount; i++)
            {
                stats.SetExperiencePoint(stats.MaxExperience + 1);
            }

            Assert.AreEqual(expectedResult, stats.Level);
        }

        [Test]
        public void set_two_max_experience_point_same_time_current_experience_point_returns_zero()
        {
            var stats = GetStats();

            int setValue = Mathf.FloorToInt(stats.MaxExperience * stats.IncreaseExperienceValue) + stats.MaxExperience;

            stats.SetExperiencePoint(setValue);

            Assert.AreEqual(0, stats.CurrentExperience);
        }
        
        [Test]
        public void set_two_max_experience_point_same_time_current_level_plus_two()
        {
            var stats = GetStats();

            int setValue = Mathf.FloorToInt(stats.MaxExperience * stats.IncreaseExperienceValue) + stats.MaxExperience;
            int expectedResult = stats.Level + 2;

            stats.SetExperiencePoint(setValue);

            Assert.AreEqual(expectedResult, stats.Level);
        }
    }
}