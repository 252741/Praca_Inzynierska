using System.Collections.Generic;
using UnityEngine;

public class BasicFigure : MonoBehaviour
{
    
    public Dictionary<string, BasicFigure> positionRegistry;
    protected string position;
    protected void Start() {
        InitPosition();
    }
    public virtual void Move(string CurPos, string DestPos){
        position = DestPos;
        positionRegistry[DestPos] = this;
        if(positionRegistry[CurPos].Equals(this)) {
            positionRegistry.Remove(CurPos);
        }
    }
    public void Die(){
        if(positionRegistry[position].Equals(this)) {
            positionRegistry.Remove(position);
        }
    }

    public void InitPosition() {
        positionRegistry = GameObject.Find("szachownica").GetComponent<Positioning>().positions;
        position = gameObject.name.Substring(gameObject.name.Length-2);
        positionRegistry.Add(position, this);
    }
}
