using UnityEngine;

public class Pawn : BasicFigure
{
    public override void Move(string CurPos, string DestPos){
        base.Move(CurPos, DestPos);
        StandardMoves.StandardMove(CurPos, DestPos);
    }
    void TakeMove(string CurPos, string DestPos){
        Move(CurPos, DestPos);
    }
    void Promote(string CurPos, string DestPos, Object Figure) {
        Move(CurPos, DestPos);
        Die();
        /**TODO: fix this later**/
        GameObject.Instantiate(Figure, new Vector3(), new Quaternion());
    }
}
