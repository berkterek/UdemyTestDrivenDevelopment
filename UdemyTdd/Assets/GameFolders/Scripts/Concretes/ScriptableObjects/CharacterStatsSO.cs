using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyTdd.ScriptableObjects
{
    [CreateAssetMenu(fileName="Character Stats",menuName = "Udemy Tdd/Stats/Character Stats")]
    public class CharacterStatsSO : ScriptableObject
    {
        [SerializeField,Min(1f)] float _moveSpeed = 1f;
        [SerializeField,Min(1f)] float _damage = 1f;
        [SerializeField,Min(1)] int _maxHealth = 1;
        [SerializeField,Min(1)] int _maxMana = 1;
        [SerializeField,Min(1)] int _level = 1;
        [SerializeField, Min(1)] int _maxExperience = 10;
        [SerializeField, Min(1f)] float _increaseExperienceValue = 1.5f; 
        
        int _currentExperience = 0;

        public float MoveSpeed => _moveSpeed;
        public float Damage => _damage;
        public int MaxHealth => _maxHealth;
        public int MaxMana => _maxMana;
        public int Level => _level;
        public int MaxExperience => _maxExperience;
        public int CurrentExperience => _currentExperience;
    }    
}