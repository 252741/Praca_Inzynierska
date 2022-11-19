public class Rook : BasicFigure
{
    public override void Move(string CurPos, string DestPos){
        base.Move(CurPos, DestPos);
        StandardMoves.StandardMove(CurPos, DestPos);
    }
    void Castle(string CurPos,string DestPos){
        base.Move(CurPos, DestPos);
        StandardMoves.HorseMove(CurPos, DestPos);
    }
}
