using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proje1.Controllers;
using Proje1.Abstract.Spawners;
using Proje1.Pool;
namespace Proje1.Spawners
{
    public class TreeEnemySpawner : BaseSpawner
    {



        protected override void Spawn()
        {
            TreeEnemyController poolTree = TreePool.Instance.Get();
            poolTree.transform.position = this.transform.position;
            poolTree.gameObject.SetActive(true);

        }

    }
}

