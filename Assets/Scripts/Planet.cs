using UnityEngine;

public class Planet : MonoBehaviour
{
    [SerializeField] private string nama;
    [SerializeField][TextArea] private string deskripsi;
    [SerializeField] private string infoDiameter;
    [SerializeField] private string infoSuhuPermukaan;
    [SerializeField] private string LamaBerputar;
    [SerializeField] private string JumlahBulan;
    [SerializeField] private Sprite gambarKartuPlanet2D;

    public string GetNama()
    {
        return nama;
    }
    public string GetDeskripsi()
    {
        return deskripsi;
    }
    public string GetInfoDiameter()
    {
        return infoDiameter;
    }

    public string GetInfoSuhuPermukaan()
    {
        return infoSuhuPermukaan;
    }

    public string GetLamaBerputar()
    {
        return LamaBerputar;
    }
    public string GetJumlahBulan()
    {
        return JumlahBulan;
    }
    public Sprite GetGambarKartuPlanet2D()
    {
        return gambarKartuPlanet2D;
    }
}

