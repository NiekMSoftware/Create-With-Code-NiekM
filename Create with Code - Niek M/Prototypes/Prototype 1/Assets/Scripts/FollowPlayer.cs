using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    [SerializeField] GameObject player;
    [SerializeField] Vector3 _offset = new Vector3(0, 5, -7);
    
    void LateUpdate() 
    {
        transform.position = this.player.transform.position + this._offset;
    }
}
