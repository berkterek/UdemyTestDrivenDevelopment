using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyTdd.Abstracts.Factories
{
    public abstract class Factory<TAbstract> where TAbstract : class
    {
        public abstract TAbstract Create();
    }
}