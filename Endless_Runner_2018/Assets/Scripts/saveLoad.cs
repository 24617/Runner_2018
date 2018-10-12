using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class saveLoad
{



    public static void SaveData(score Score)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream stream = new FileStream(Application.persistentDataPath + "/data.sav", FileMode.Create);

        scoreData data = new scoreData(Score);

        bf.Serialize(stream, data);
        stream.Close();
    }

    public static float[] LoadData()
    {
        if (File.Exists(Application.persistentDataPath + "/data.sav"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream = new FileStream(Application.persistentDataPath + "/Data.sav", FileMode.Open);

            scoreData Data = bf.Deserialize(stream) as scoreData;
            Debug.Log("u svaed us!");
            stream.Close();
            return Data.stats;

        }

        return null;
    }

    [Serializable]
    public class scoreData
    {
        public float[] stats;
        public scoreData(score Score)
        {
            stats = new float[1];
            stats[0] = Score.myScore;
        }
    }
}
