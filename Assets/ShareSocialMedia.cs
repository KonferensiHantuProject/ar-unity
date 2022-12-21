using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class ShareSocialMedia : MonoBehaviour
{
    [SerializeField] GameObject SharePanel;
    [SerializeField] Text txtShare;

    public void ShareAdvertisement()
    {
        // Preparing Share Stuff
        txtShare.text = "Ini adalah Pesan yang Dishare via Unity";

        // Open Share Panel
        SharePanel.SetActive(true);

        StartCoroutine("TakeScreenShotAndShare");
    }

    IEnumerator TakeScreenShotAndShare()
    {
        yield return new WaitForEndOfFrame();

        Texture2D tx = new Texture2D (Screen.width, Screen.height, TextureFormat.RGB24, false);
        tx.ReadPixels (new Rect(0, 0, Screen.width, Screen.height),0,0);
        tx.Apply ();

        string path = Path.Combine(Application.temporaryCachePath, "sharedImage.png");
        File.WriteAllBytes (path, tx.EncodeToPNG ());

        Destroy(tx);

        new NativeShare ()
            .AddFile (path)
            .SetSubject("Ini yang saya share")
            .SetText("Berbagi agar dapat poin")
            .Share();

        SharePanel.SetActive(false);
    }
}
