class StandardMoves {
    public static void StandardMove(string CurPos, string DestPos){
        UnityEngine.MonoBehaviour.print("MOVED FROM: " + CurPos + " TO " + DestPos);
    }
    public static void HorseMove(string CurPos, string DestPos){
        UnityEngine.MonoBehaviour.print("JUMPED FROM: " + CurPos + " TO " + DestPos);
    }
}