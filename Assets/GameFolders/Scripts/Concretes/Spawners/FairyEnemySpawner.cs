using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proje1.Controllers;
using Proje1.Abstract.Spawners;
namespace Proje1.Spawners
{using Proje1.Pool;
    public class FairyEnemySpawner : BaseSpawner
    {
        protected override void Spawn()
        {
            FairyEnemyController poolFairy = FairyPool.Instance.Get();
            poolFairy.transform.position = this.transform.position;
            poolFairy.gameObject.SetActive(true);

        }

    }
}

