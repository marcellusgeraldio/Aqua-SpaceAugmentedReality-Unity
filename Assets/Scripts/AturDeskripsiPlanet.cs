using UnityEngine;
using UnityEngine.UI;

public class AturDeskripsiPlanet : MonoBehaviour
{
    private bool[] isMarker;
    private GameObject planet;
    private int hitungMarker;
    [SerializeField] int jmlMarker;

    [Header("Elemen UI Utama")]
    [Tooltip("Teks nama planet di pojok kiri atas layar.")]
    [SerializeField] private Text txNamaPlanetAtas;

    [Tooltip("Panel yang berisi semua deskripsi dan fakta detail planet.")]
    [SerializeField] private GameObject panelDetailPlanet; 

    [Header("Teks di Dalam Panel Detail Planet")]
    [SerializeField] private Text txDeskr; 
    [SerializeField] private Text txInfoDiameter; 
    [SerializeField] private Text txInfoSuhu;     
    [SerializeField] private Text txInfoLamaPutar; 
    [SerializeField] private Text txInfoBulan;    
    [SerializeField] private Image uiImageDisplayKartu;


    private bool tampilkanPanelDetailPreference = true; 

    private void Start()
    {
        isMarker = new bool[jmlMarker];
   
        if (txNamaPlanetAtas != null) txNamaPlanetAtas.gameObject.SetActive(false);
        if (panelDetailPlanet != null) panelDetailPlanet.SetActive(false);
    }

    public void SetMarkerOn(int indexMarker)
    {
        if (indexMarker < 0 || indexMarker >= isMarker.Length) return; 
        if (!isMarker[indexMarker])
        {
            isMarker[indexMarker] = true;
            hitungMarker++;
        }
    }

    public void SetMarkerOff(int indexMarker)
    {
        if (indexMarker < 0 || indexMarker >= isMarker.Length) return; 
        if (isMarker[indexMarker])
        {
            isMarker[indexMarker] = false;
            hitungMarker--;
            if (hitungMarker < 0) hitungMarker = 0;
        }
    }

    public void SetPlanet(GameObject planetDariAR) 
    {
        this.planet = planetDariAR;
        // Jika planet baru di-set, mungkin kita ingin panel detail selalu coba tampilkan lagi (jika marker ada)
        // Ini tergantung preferensi. Untuk sekarang, kita biarkan status minimize diingat.
        // Jika ingin selalu reset saat planet baru:
        // tampilkanPanelDetailPreference = true;
    }

    private void SetUI(bool MarkerDetected)
    {
        if (MarkerDetected)
        {
            if (txNamaPlanetAtas != null)
            {
                txNamaPlanetAtas.gameObject.SetActive(true); 
            }

            if (panelDetailPlanet != null)
            {
                if (tampilkanPanelDetailPreference)
                {
                    panelDetailPlanet.SetActive(true);
                }
                else
                {
                    panelDetailPlanet.SetActive(false); 
                }
            }
        }
        else
        {
            if (txNamaPlanetAtas != null)
            {
                txNamaPlanetAtas.gameObject.SetActive(false);
            }
            if (panelDetailPlanet != null)
            {
                panelDetailPlanet.SetActive(false);
            }
        }
    }

    public void TombolTutup()
    {
        if (panelDetailPlanet == null) return;

        if (hitungMarker > 0 && planet != null)
        {
            tampilkanPanelDetailPreference = !tampilkanPanelDetailPreference;
            panelDetailPlanet.SetActive(tampilkanPanelDetailPreference);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (hitungMarker == 0)
        {
            SetUI(false);
            return;
        }

        if (planet != null)
        {
            SetUI(true); 

            Planet planetData = planet.GetComponent<Planet>();

            if (planetData != null)
            {
                if (txNamaPlanetAtas != null)
                {
                    txNamaPlanetAtas.text = planetData.GetNama();
                }

                // 2. Atur teks di dalam panelDetailPlanet (ini hanya akan terlihat jika panelDetailPlanet aktif)
                // Loop ini tetap ada sesuai struktur kode Anda.
                // Perhatikan: Memanggil GetComponent di dalam loop berulang kali kurang efisien.
                // Jika memungkinkan, panggil GetComponent<Planet>() sekali saja sebelum loop.
                // Namun, untuk mengikuti pola Anda:
                for (int i = 0; i < isMarker.Length; i++)
                {
                    if (txDeskr != null) txDeskr.text = planet.GetComponent<Planet>().GetDeskripsi();
                    if (txInfoDiameter != null) txInfoDiameter.text = planet.GetComponent<Planet>().GetInfoDiameter();
                    if (txInfoSuhu != null) txInfoSuhu.text = planet.GetComponent<Planet>().GetInfoSuhuPermukaan();
                    if (txInfoLamaPutar != null) txInfoLamaPutar.text = planet.GetComponent<Planet>().GetLamaBerputar();
                    if (txInfoBulan != null) txInfoBulan.text = planet.GetComponent<Planet>().GetJumlahBulan();
                    if (uiImageDisplayKartu != null) uiImageDisplayKartu.sprite = planetData.GetGambarKartuPlanet2D(); 
                }
            }
        }
        else 
        {
            SetUI(false);
        }
    }
}