using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jinryjiemian : MonoBehaviour {

	public Text text;
	public int bz;
    string hua;
    public int jieshu;

    public GameObject cunzhang;
    public GameObject guaiwu;
	// Use this for initialization
	void Start () {
        Time.timeScale = 0;
        neirong();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void xiayibu()
    {
        bz++;
        if (bz == jieshu)
            kaishi();
        else
            neirong();
    }


    public void kaishi()
    {

        Time.timeScale = 1;
        gameObject.SetActive(false);
        guaiwu.SetActive(true);
        cunzhang.SetActive(false);
    }

	void neirong()
    {
        switch (bz)
        {
            case 0:
               hua= "主人公：村长，好巧遇到了你，你最近在干什么？";
                break;
              
            case 1: 
                hua=" 村长：最近我们村庄发生了一些细微的变化，总觉得哪里怪怪的但又看不出来，所以我才来调查此事。";
                break;
            case 2:
                hua = "主人公：诶？村长你看，那里怎么长出了一株奇异的鲜花，以前这里不是寸草不生吗？";
                break;
            case 3:
                hua = "村长：这……这难道是压制在这里的灵力爆发了？快跑！";
                break;
            case 4:
                hua = "主人公：怪物出现了！村长你先跑，我来会会他们！！";
                break;
            case 5:
                hua = "主人公：啊，终于应付过去这些怪物了，还是要赶紧调查清楚这是怎么回事！";
                break;
            case 6:
                hua = "村长：此事还要追溯到100年前……从前有一个灵力超群的人途径我们村庄却突遭不测，他在死前把自身灵力封印在了我们村庄，此后我们村庄隔一段时间就会发生了些奇怪的事情，在我们村的村志中也有描述，但大家都不知道该如何结束这一切……";
                break;
            case 7:
                hua = "主人公：我曾听我爷爷说起，我们的祖先也曾镇压过这些灵力。还专门给我们后代写了一本秘籍，我这就取来给你看！";
                break;
            case 8:
                hua = "村长：快回头！远处亮光的是什么？快跑！！";
                break;
            case 9:
                hua = "主人公：不行，这是我回家的必经之路，村长，你就在原地等我，待我打败他们我速速就回！";
                break;
            case 10:
                hua = "主人公：村长，我回来啦，我知道怎么结束这一切啦！！";
                break;
            case 11:
                hua = "村长：这么快？你准备怎么制服我？就凭你？一个黄毛丫头？谁给你的勇气";
                break;
            case 12:
                hua = "主人公：我知道你的弱点，待我打败你之后取走那株你灵力化成的妖花，你就再也不能扰我们村庄的清净了。";
                break;
            case 13:
                hua = "村长：那就看你有没有这个本事了！";
                break;
            case 14:
                hua = "主人公：接招！";
                break;

        }
        text.text = hua;
    }
}
