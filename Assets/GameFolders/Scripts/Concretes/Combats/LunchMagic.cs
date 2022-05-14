using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proje1.Controllers;


namespace Proje1.Combats
{
    public class LunchMagic : MonoBehaviour
    {
        [SerializeField] PlayerMagicController _projectTilePrefab;
        [SerializeField] Transform _projectTileTransform;
        [SerializeField] GameObject _strogeMagics;

        [SerializeField] float _coolDown = 1f;
      
        public bool _canLunch = true;


        public IEnumerator LunchAction()
        {
            if (_canLunch)
            {
                _canLunch = false;
                PlayerMagicController newFire = Instantiate(_projectTilePrefab, _projectTileTransform);
                newFire.transform.parent = _strogeMagics.transform;
                yield return new WaitForSeconds(_coolDown);
                _canLunch = true;
            }



        }
    }

}
