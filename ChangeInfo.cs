using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class ChangeInfo : MonoBehaviour
{
    public Text title;
    public Text description;
    public RawImage image;

    private Texture2D myTexture;
    private Sprite mySprite;

    //string titulo = "Monet";
    /*string descripcion = @"Cuando decide dedicarse a la pintura, va a París atraído por Delacroix, Corot y Daubigny. Acude a la Academia Suisse, que ofrecía a los alumnos total libertad para trabajar ante los modelos vivos.Sin embargo, a los dos años de su llegada a París, tuvo que abandonar su aprendizaje y cumplir el servicio militar.En 1862, después de su licenciamiento regresa a Le Havre y prosigue con su actividad como pintor.Retoma el contacto con Boudin y conoce a Jongkind, paisajista holandés a quien Monet considera su verdadero maestro, el que educó su percepción visual.\n
                              Ese mismo año, Monet vuelve a París e ingresa en el estudio Gleyre, allí conoce a Bazile, Sisley y Renoir, pintores franceses con los que más tarde formará el grupo impresionista.Con Bazile va a pintar del natural al bosque de Fontainebleau, cerca de Barbizón.También irán a la célebre Ferme Saint - Simeón, en la costa normanda, que es el punto de encuentro para los pintores de marinas y que desempeña un papel similar al de Barbizón en el bosque de Fontainebleau.\n
                              En 1866, durante su estancia en Ville d'Avray, creó excepcionales cuadros de figuras con paisajes.Almuerzo al aire libre se trata de una reunión de amigos en la naturaleza. Es una excusa para representar el paisaje con objetos que se transforman con la luz.Es un estudio de luz y color, aunque de momento aquí, la luz sólo modifica el color, no dibuja la forma, ya que esto es algo que creará más adelante.\n
                              Para Mujeres en el jardín, posó la modelo Camille Doncieux, mujer que poco después se convertiría en su esposa.Monet presentó esta obra al Salón de 1867 y fue rechazada por el jurado.\n
                              Tras una época de penuria económica, en otoño de 1871, Monet se traslada a Argentuil, donde pasará una de las temporadas más felices de su vida.Pintaba a menudo en las aguas del sena, sobre un bote que había convertido en una especie de taller flotante.Se interesaba por representar los efectos de la luz y el color en los paisajes.Durante este periodo produjo Las barcas, regatas en Argentuil, prescindiendo del color negro.La iluminación proviene de las velas y de los reflejos de la superficie del agua del río.\n
                              Su estancia en Argentuil fue clave para la fijación del grupo y de las normas impresionistas, que dieron la espalda al arte oficial. Renoir, Sisley, Pisarro, Cézanne, Degas, Gaullaumin y Morisot junto con Monet decidieron organizar una exposición privada fuera de la influencia del Salón Oficial. En 1874 celebraron su primera exposición colectiva en la Sala del fotógrafo Nadar.Monet envió a la muestra Impresión, sol naciente, obra por la que el crítico Leroy los denominó de forma peyorativa impresionistas.La observación del mundo cambiante y el estudio de la atmósfera en continuo movimiento lo lleva a representar un momento concreto, la salida del sol y el reflejo de los rayos sobre las tranquilas aguas del mar.";
    */
    //public Sprite imagen;
    /*
    private void Start()
    {
        StartCoroutine(GetTexture());
    }

    IEnumerator GetTexture()
    {
        UnityWebRequest www = UnityWebRequestTexture.GetTexture("https://upload.wikimedia.org/wikipedia/commons/thumb/3/32/Peeter_gysels_%28attr.%29%2C_mercato_di_cavalli.JPG/1280px-Peeter_gysels_%28attr.%29%2C_mercato_di_cavalli.JPG");
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            myTexture = ((DownloadHandlerTexture)www.downloadHandler).texture;
        }
    }
    */
    public void Awake()
    {
        //myTexture = Resources.Load("1", typeof(Texture2D)) as Texture2D;
    }
    /*
    public void readTxt(ref string tit, ref string des, string id)
    {
        System.IO.StreamReader file = new System.IO.StreamReader(Application.dataPath + "/Resources/info/"+id+".txt");
        tit = file.ReadLine();
        des = "";
        string line = file.ReadLine();

        while (line != null)
        {
            des += (line + "\n");
            line = file.ReadLine();
        }
        file.Close();
    }
    */

    public void readTxt(ref string tit, ref string des, string id)
    {
        TextAsset txtAsset = (TextAsset)Resources.Load("info/" + id, typeof(TextAsset));
        string textFile = txtAsset.text;

        tit = "";
        des = textFile;
    }

    public void upDateInfo(string id)
    {
        //string info = Resources.Load<TextAsset>("info/1").text;
        //info = info.Split('\n')[0];
        string titulo = "", descripcion = "";
        readTxt(ref titulo, ref descripcion, id);
        //title.GetComponent<Text>().text = titulo;

        title.text = titulo;
        description.text = descripcion;
        //image.sprite = Resources.Load<Sprite>("sprites/" + id);
        myTexture = Resources.Load("sprites/" + id, typeof(Texture2D)) as Texture2D;
        //Sprite mySprite = Sprite.Create(myTexture, new Rect(0.0f, 0.0f, myTexture.width, myTexture.height), new Vector2(0.5f, 0.5f), 100.0f);
        //image.texture = myTexture;
        image.texture = myTexture;

        //description.GetComponent<Text>().text = descripcion;// Resources.Load<TextAsset>("info/1").text;
        //image.GetComponent<Image>().sprite = Resources.Load<Sprite>("sprites/" + id);
        
        
        
        //image.GetComponent<Image>().material.SetTexture("_MainTex", myTexture);
    }
}
