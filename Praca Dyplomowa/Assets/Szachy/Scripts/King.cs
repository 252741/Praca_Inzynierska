public class King : BasicFigure
{
    public override void Move(string CurPos, string DestPos){
        base.Move(CurPos, DestPos);
        StandardMoves.StandardMove(CurPos, DestPos);
    }
    void Castle(string CurPos,string DestPos){
        Move(CurPos, DestPos);
    }
}
