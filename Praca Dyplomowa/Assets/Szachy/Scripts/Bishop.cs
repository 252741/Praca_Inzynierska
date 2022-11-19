public class Bishop : BasicFigure
{
    public override void Move(string CurPos, string DestPos){
        base.Move(CurPos, DestPos);
        StandardMoves.StandardMove(CurPos, DestPos);
    }
}
