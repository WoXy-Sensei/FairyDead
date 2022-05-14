using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proje1.Abstract.Pool;
using Proje1.Controllers;
namespace Proje1.Pool
{
    public class TreePool : GenericPool<TreeEnemyController>
    {
        public static TreePool Instance {get;private set;}

        protected override void SingletonObject()
        {
            if(Instance == null){
                Instance = this;
                
            }else{
                Destroy(this.gameObject);
            }
        }
    }
}

