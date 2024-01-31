using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class LevelPieceBaseSetup : ScriptableObject
{
    public ArtManager.ArtType artType;

    [Header("Pieces")]
    public List<LevelPieceBase> levelPiecesStart;
    public List<LevelPieceBase> levelPieces;
    public List<LevelPieceBase> levelPiecesEnd;

    public int piecesStartNumber = 1;
    public int piecesNumber = 3;
    public int piecesEndNumber = 1;
}
