using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proje1.Controllers;


namespace Proje1.Combats
{
    public class LunchEnemyMagic : MonoBehaviour
    {
        [SerializeField] EnemyMagicController _projectTilePrefab;
        [SerializeField] Transform _projectTileTransform;
         GameObject _strogeMagics;





        public void LunchAction()
        {

            EnemyMagicController newFire = Instantiate(_projectTilePrefab, _projectTileTransform);
            _strogeMagics = GameObject.Find("MagicStroge");
           newFire.transform.parent = _strogeMagics.transform;





        }
    }

}
