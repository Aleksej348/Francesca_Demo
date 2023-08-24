using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prologue : Story
{
	private IEnumerator Z1()
	{
		st.CoroutineBegining();
		switch(st.step)
		{
			case 0:
				st.step=1;
				goto case 1;
			case 1:
				st.SetMaterial(0,new Dictionary<string,float> { { "_WaveSpeed",2.5f },{ "_WaveAmplitude",0.003f } });
				Scene(11,true,true);
				PlayMusic(4);
				yield return StartCoroutine(act.FadeDown("<color=red>��������!</color>\r\n��� ��������� � ����������� ������� �������� ������������.\r\n����� ���������� � ��������� ������ ��� ���������,�������� ������������.\r\n������ ���� �������� � ���� ������ �������,�������,����� ������� � ����������� ���������.\r\n������ ���� �� �������� ����������� ����������,������� ��� ���� �� �������.\r\n<color=red>�� ������������� �����,�� ��������� 18 ���,�� ������ �������� ��� ����������.</color> ",3f));
				if(language==1)
					Say("sh","�������, �� ���������, ��� � ���� ����? ");

				else
					Say("sh","Remember when you asked me how I was doing?");
				break;
			case 2:								
				if(language==1)
					Say("sh","� �� �����, ����� ��� ���� ��� ��� � ��� ���� ��������");

				else
					Say("sh","I don't remember when it was or what I answered you there.");
				break;
			case 3:						
				if(language==1)
					Say("sh","�� � �� ����� ���");

				else
					Say("sh","Yes, and it doesn't matter");
				break;
			case 4:								
				if(language==1)
					Say("sh","������ ��� ���");

				else
					Say("sh","I will answer again");
				break;
			case 5:			
				if(language==1)
					Say("sh","� �� �����, ��� ��� ��. ");

				else
					Say("sh","I don't think everything is ok.");
				break;
			case 6:				
				Fade();
				yield return new WaitForSecondsRealtime(2f);
				Scene(0);
				SecondScene(0);
				if(language==1)
					Think("������ �����, ����������� �� �������, ��������, � ������� ��� �� � ��� �� ������ ������� ������ �� ��������� ���������, ����������� � ������ ��������. ������,��������� �����,�����������.�� ���� �� � ������.����,��� ������,� ����.");
				else
					Think("The green light, announcing online, goes out, and Sukachev, as if nothing had happened, points the cursor at the blue arrow, returning to the list of dialogues.The fingers squeezing the mouse tremble.But it's not the nerves. The thing is, as always, dope.");
				break;
			case 7:
				if(language==1)
					Say("a","� ���� ��� ���� �� �������� �� ��������.");
				else
					Say("a","Didn't even make it to midnight this time.");
				break;
			case 9:
				PlaySound(3);
				if(language==1)
					Say("a","��� ��������, ����, �� �� �������, � ������ ����� ������ �� ���� ���������! ");
				else
					Say("a","Seriously, Zhenya, you are not a groupie, but a waste of charge on my Francesca!");
				break;
			case 8:
				if(language==1)
					Say("a","����� ���� �������� � � ���� � ����");
				else
					Say("a","It was necessary to throw her in the block to Fedya");
				break;
			case 10:				
				PlaySound(0);
				Messenger(6,0);
				if(language==1)
					Say("������� �������","�� ����� �, �����, �������");
				else
					Say("ANDRYUSHA SUKACHEV","Yes, I'll come, I'll come, fucked up.");
				break;
			case 11:
				PlaySound(0);
				Messenger(6,1);
				PlaySound2(5);
				if(language==1)
					Say("������� �������","������ ��� ���� �������, � ����� � ���� ");
				else
					Say("ANDRYUSHA SUKACHEV","I'll twist another joint, and immediately to you.");
				break;
			case 12:
				PlaySound(0);
				Messenger(6,2);
				if(language==1)
					Say("������� �������","�� �� ���, ������ ���, �� ����������, ����� ������ ����� ����� ����� �����");
				else
					Say("ANDRYUSHA SUKACHEV","Well, you are, look there, do not decompose, what a fucking smell after that.");
				break;
			case 13:
				PlaySound(0);
				Messenger(6,3);
				if(language==1)
					Say("������� �������","��� ��� ���� ������� �������� � ������� ����");
				else
					Say("ANDRYUSHA SUKACHEV","So be a good girl and wait for me.");
				break;
			case 14:
				PlaySound(0);
				Messenger(6,4);
				if(language==1)
					Say("������� �������","����? �� ���� � � ���� ��� �� ���������, �� ������ �� ��� ������ ����, ����, ����?");
				else
					Say("ANDRYUSHA SUKACHEV","OK? But if this time it doesn�t work out, then you�ll somehow go on your own, okay, Zhenya?");
				break;
			case 15:
				PlaySound(0);
				Messenger(6,5);
				if(language==1)
					Say("������� �������","�� ���� �������. ��� ���� ���� �� ����, � �� ���� �� �����������, � ��� ���� ��� ���� ����");
				else
					Say("ANDRYUSHA SUKACHEV","Well, think for yourself. It's not even a block, I'm not giving up on you, but giving you one more chance.");
				break;
			case 16:
				PlaySound(0);
				Messenger(6,6);
				if(language==1)
					Say("������� �������","�� ����� � �� �������? ");
				else
					Say("ANDRYUSHA SUKACHEV","Well, am I not good?");
				break;
			case 17:
				PlaySound(0);
				Messenger(6,7);
				if(language==1)
					Say("������� �������","����� ������, � ����� ������! ");
				else
					Say("ANDRYUSHA SUKACHEV","The best, I'm the best!");
				break;
			case 18:
				PlaySound(0);
				Messenger(6,8);
				if(language==1)
					Say("������� �������","� �� ��� ���� �����, ����-�� � �����. ");
				else
					Say("ANDRYUSHA SUKACHEV","And all for you alone, Fedya is in the block.");
				break;
			case 19:
				yield return StartCoroutine(act.Glitch(12,true));
				if(language==1)
					Say("a","��� ��� ���� ���");
				else
					Say("a","Or is it for you...");
				break;
			case 20:
				if(language==1)
					Say("a","��� �� ��� ��������? ");
				else
					Say("a","How did you say it?");
				break;
			case 21:
				if(language==1)
					Say("a","��� ����? ");
				else
					Say("a","\"Not okay\"?");
				break;
			case 22:
				if(language==1)
					Say("a","�� ��� �� ������ ��� �����");
				else
					Say("a","Well, it doesn�t happen that way, �okay�");
				break;
			case 23:
				if(language==1)
					Say("a","�� ������ ��������� �� �������� � ������� ��� ���");
				else
					Say("a","You just press a button and do this...");
				break;
			case 24:
				if(language==1)
					Think("������ ���������, ��� ����� ��������� � �����, � ������������ ��������� �������� �����. ");
				else
					Think("Andrey feels how the player rests on his temple, and with a practiced movement he raises the trigger.");
				break;
			case 25:
				if(language==1)
					Think("������, ����� ������� ��������� ����� � ����������� ����, ������� ������ ������ ����� � ������ �����, �� ������ ������ ����� ������� � ����������. ���� ��� ��� ��������� � �����, �� ��� ������, ��� ����� �������, � �� ������ ���������� ������� ������ ��������� �����.");
				else
					Think("Now, when the lever flaunts next to the half-erased \"on\", all that remains is to enter the time and press the play, but Andrei instead reaches for the ashtray. The muzzle still rests against the temple, so tightly that you push harder, and Andryushin's rotten brains will splatter on the green plastic.");
				break;
			case 26:
				if(language==1)
					Think("���������� ����� ���, ��� ���������, � ������ ������ � ��� ���������� �����. ������ ��� �������� � ��� ����� ��� ����� ���, ��� ����� �� �� ��������. � ������� �������� ������, ����������? ");
				else
					Think("The ashtray stands in such a way that a moment, and instead of a cigarette butt, it turned out to be a blunt. Andrey has been playing around like that ever since, since there was no time for bookmarks. From the first Thursday of the month, right?");
				break;
			case 27:
				if(language==1)
					Think("������ ������������: ����� ��� �������� �� ����, ������, ��������� ���������, ������, �� ��� �� ������ ���������� �� ����������, ����������� ������������ � ���� ��� ���������� ������ ���������. ");
				else
					Think("Andrey takes a puff: his eyes are already watering from the smoke, the fingers squeezing Francesca are going numb, but he himself only closed his eyes in bliss, enjoying the seconds added to the fund �until the next jump�.");
				break;
			case 28:
				if(language==1)
					Think("��������� �����������, � ����������� �� ������ ������� �� ������, ��� ��� ���� ���������� �� ����� � ����������� ��� ������ ������� ��������� ����������, � ����� ���� ������ � ����, �����, �������. ");
				else
					Think("The intervals are shortening, and there are more and more toys disassembled into parts, they can barely fit on the table - the filler for soft toys clings to the plastic, and between them there are laces and chains, fabric, cartridges.");
				break;
			case 29:
				if(language==1)
					Think("� ���������� ��������� �� ����� �������� ���������, ��� ������. ");
				else
					Think("Francesca has nothing to do with the burial ground, this is personal.");
				break;
			case 30:
				if(language==1)
					Think("������ �������� �� � �������, �� �����������, ������ �� ������-������ � ��������. �� �� ��� �� �� �������� ���� ���������. ");
				else
					Think("Andrey rakes them aside, without hesitation, further from the holy of holies - batteries. But still does not lower his Francesca.");
				break;
			case 31:
				if(language==1)
					Think("�������� �����, ���� ����. ������ ������ ��������� ���������, ����������� �������, ���� ������ � ��������� ������ �������� ��� ����� ������� ����� �����, � ��� �� ���������.");
				else
					Think("Strange thing, this fund. Andrei spends hours calibrating Francesca, setting up scripts, looking for a way to abuse as many tasks as possible in a few clicks, and this does not count.");
				break;
			case 32:
				if(language==1)
					Think("�� ��� �������� ���� ����� � ���� �������, ���� ������� � ���-���, � ����� ����� �� ������� ������ �� ����");
				else
					Think("But to sit for five minutes in your own time, while he enters the chat bot, and the finger immediately reaches out to click on the play ...");
				break;
			case 33:
				yield return StartCoroutine(act.Glitch(0));
				Show("a","�����");
				StartDissolve("a",0);
				if(language==1)
					Think("����� ��� ������: ��, ��� � �� �������, ������� ������� ������� � ���������� � ������� �� �������� ������������ �� ��� ������� �� �����. ");
				else
					Think("Just like now: he, without finishing his cigarette, throws the rest back into the ashtray and clicks on the red triangle ... But the world remains in place.");
				break;
			case 34:
				if(language==1)
					Think("������ �� ��� �� ���������. ������, ������� �����, ��� ���� �� �������� ������ �� ������, ������������ ����� ������� �� ������� � ������� ������, � ������ ���������� ��� ���. ����� ��������� � ������� �������, �� �� ��� �� � ��� �� ������ ���������� ��������� � ����� ��������� ��������� ");
				else
					Think("Andrey does not respond to this. Covering his eyes, he watches how the light from the monitor plays on the chips, highlights the fingerprints on the dusty and dirty glass, and enters the coordinates again. This happened to Andrey for the first time, but he, as if nothing had happened, interrupts the settings and launches Francesca again ...");
				break;
			case 35:
				if(language==1)
					Think("�� ������ �� ����������. ");
				else
					Think("But nothing happens.");
				break;
			case 36:
				PlaySound(29);
				if(language==1)
					Think("�������� ������ ������, � �� ���� ��. ��� ������� �� �����. ���������� ������� �� �����. ");
				else
					Think("A dull click is heard, and that's it. The world remains in place. The ashtray remains in place.");
				break;
			case 37:				
				if(language==1)
					Think("������ � ��� ������ �� ������� ���������, ��� �� ����� ���� ���� ��� ��������� �� ��� ����� ������� �� ������, �� ������ ������������� ��������� � ����� ��������, �� � ��� �� �����. ");
				else
					Think("Andrey is not too worried about this misfire, in fact, the whole world does not bother him too much, he just reloads Francesca and shoots again, all at the same temple.");
				break;
			case 38:
				PlaySoundMultTimes(29,2);
				if(language==1)
					Think("������. ������. ��� ���. ");
				else
					Think("Click. Silence. Again.");
				break;
			case 39:
				PlaySoundMultTimes(29,3);
				if(language==1)
					Think("������. ������. ��� ���. ");
				else
					Think("Click. Silence. Again.");
				break;
			case 40:
				Thrill("a");
				PlaySound2MultTimes(29,15);
				if(language==1)
					Think(RichText("<shake>������, ������, ������, ������, ������ ������, ������, ������, ������.</shake> ",Color.red));
				else
					Think(RichText("Click, click, click, click, click click, click, click, click.",Color.red));
				break;
			case 41:
				if(language==1)
					Think(RichText("<shake a=3>������</shake>",Color.red));
				else
					Think(RichText("SILENCE.",Color.red));
				break;
			case 42:				
				PlaySound(27);
				Dissolve("a",1);
				if(language==1)
					Say("a","*������*");
				else
					Say("a","*laughs*");
				break;
			case 43:
				PlayMusic(9);
				st.SetMaterial(0,new Dictionary<string,float> { { "_WaveSpeed",3f },{ "_WaveAmplitude",0.02f } });
				LongShaker(1f,3f);
				ZoomBackground(new Vector3(3f,3f),0.5f);
				Zoom("a",new Vector3(1.5f,1.5f),0.5f);
				Thrill("a");
				if(language==1)
					Think("���� ������� �� ����� ����������, ��������� ������, ������ �� �����. ");
				else
					Think("The sound of an ashtray flying from the table, broken glass, hitting the table.");
				PlaySound2(1);
				yield return new WaitForSecondsRealtime(0.2f);
				PlaySound(24);
				yield return new WaitForSecondsRealtime(0.5f);
				PlaySound2(21);
				yield return new WaitForSecondsRealtime(0.1f);
				ZoomBackground(new Vector3(1f,1f),0.5f);
				Zoom("a",new Vector3(1f,1f),0.5f);
				PlaySound(24);
				yield return new WaitForSecondsRealtime(0.4f);
				PlaySound2(1);
				yield return new WaitForSecondsRealtime(0.2f);
				PlaySound(24);				

				break;
			case 44:				
				Dissolve("a",0);
				PlaySound(30);
				if(language==1)
					Think("���� � �����. ");
				else
					Think("Knock on the door.");
				break;
			case 45:
				PlaySoundMultTimes(29,3);
				if(language==1)
					Think("������ ��� ��� ������� �� ����. ��� ��������� �  ������������ ����� ���� � �������.");
				else
					Think("Andrey once again clicks on the play. His Francesca is the only whole thing in the room.");
				break;
			case 46:
				if(language==1)
					Think("� ������, �������� �� �����.");
				else
					Think("And a head sticking out of the door.");
				break;
			case 47:
				Move("a","����",0.5f);
				Mirror("a",new Vector3(-1f,1f));
				Show("s","�����",new Vector3(-1f,1f));
				StartDissolveWithColor("s",0,Color.black);
				if(language==1)
					Say("???","���������, � ��� �������? ");
				else
					Say("???","Finished, I understand?");
				break;
			case 48:
				if(language==1)
					Say("???","�, ���� ������, ��� �������� ���� �����, �������. ");
				else
					Say("???","To be honest, I'm already tired of waiting for you, Sukachev.");
				break;
			case 49:
				Dissolve("a",2);
				if(language==1)
					Think("���, ��� ������. ��������� �� ������������, � ������ ���� ��� ��� ������� ��������. ������������, ��� ����� �� �������� ����������. � ���������? ");
				else
					Think("No, this is a lie. Francesca is not the only one, Andrei also has his favorite pistol. The only thing that remained untouched besides her. But other?");
				break;
			case 50:
				if(language==1)
					Think("������������ �������� ������� ����������, ����������� ����� ����������� �������� ������������� �� ���� ������. ���������� ������ ���������. ����� ������, ������, �����, �� ����� ����� ���� �������� � �������. ���� ������������� �������, � ������ �������� �����. ");
				else
					Think("An overturned broken computer monitor, a useless pile of scrap metal surrounds Andrey hunched on the floor. Batteries covered in blood. Broken glass, cigarette butts, ashes, from all this carries dampness and iron. The hand is unnaturally arched, it is not shaking at all well.");
				break;
			case 51:
				if(language==1)
					Think("��, ��� ���� �����, � ���� �������� ������ �� �����, ���� � ����, ��� ���������� �����, �� �������� �� �����. �� � ���������� ������� ������� ����� � ���������, ������� � ����������� �����. ��, ��� �������� �� ������ ����, ������� ������ ������, � ��� ������ � ������ �  �������� �� �������� ������, ���� �� ������ �����.");
				else
					Think("Everything below the elbow is one continuous mess of blood, meat and what looks like bones, but Sukachev doesn�t care. He is squeezing in his peeled fingers a whole and invisible barrel squeezed from the collector. What is left of the right arm seems to be a dead weight, and it is only for consumption - cut off at the shoulder joint until it starts to rot.");
				break;
			case 52:
				if(language==1)
					Think("���� ����� �������, ������� ����� �� ����� �����������. ���, ��� ������ ���� ����, � ���� ������������ ��������� ������ �����. ����� ���� � ���� ���������� ����������� � �� ������� ������, ����� �����������, ����������� �� �� ��������� �������, ������� ��������. ");
				else
					Think("The muzzle shakes, Sukachev can't aim. Where there should be a target, he has a bad black spot. When the ringing in the ears becomes unbearable and there is nothing left but a chirring, unceasing darkness for a moment, Sukachev shoots.");
				break;
			case 53:
				EndDissolve("a");
				EndDissolve("s");
				GunFire(2,1f); 
				if(language==1)
					Think("�������. �����������. "+RichText("<shake>��� ����.</shake>",Color.red));
				else
					Think("SHOT. RECHARGE. "+RichText("<shake>ANOTHER ONE.</shake>",Color.red));
				break;
			case 54:
				GunFire(10,0.5f);
				if(language==1)
					Think(RichText("<shake a=5>� �٨. � �٨. �٨, �٨, �٨. </shake>",Color.red));
				else
					Think(RichText("<shake a=5>AND FURTHER. AND FURTHER. MORE MORE MORE.</shake>",Color.red));
				break;
			case 55:
				if(language==1)
					Think("��� ������ � �����, � ����� ����� �� ��� ������������, ��� �� ����� ����� �����.� ���� �� ���� ������ ��������,�������� �� ������ ������ � �����.���,�� ������ ����� � ������,�������,������,�� ������ �������� ���� � ��� �� ������ ������ �� ��� ������������ ������� ������� ���� ?");
				else
					Think("The entire clip is in the door, and the white mask is still the only thing he sees in front of him.And if Andrey's plan had worked, only shell casings and blood would have remained.No, not only blood and shell casings, Sukhachev, wake up, bodies remain from the dead, and what are you going to do with one hundred and fifty pounds of rotten meat?");
				break;
			case 56:				
				StartDissolve("a",0);
				if(language==1)
					Say("a","������ �� ������?");
				else
					Say("a","Why are you now...?");
				break;
			case 57:
				if(language==1)
					Think("���������� � ���������, �� �������� ��� �� ���.");
				else
					Think("He asks Francesca, but she does not answer him.");
				break;
			case 58:				
				StartDissolveWithColor("s",0,Color.black);
				if(language==1)
					Say("???","������� � ������ ���? ");
				else
					Say("???","\"Why me now\" what?");
				break;
			case 59:
				if(language==1)
					Say("???","������� ���� ����������� �����? ");
				else
					Say("???","Cracked your electronic lock?");
				break;
			case 60:
				if(language==1)
					Say("???","�������� ������������? ");
				else
					Say("???","Turned off the alarm?");
				break;
			case 61:
				if(language==1)
					Say("???","�������� � ���� ������ ������?");
				else
					Say("???","Looked into your holy of holies?");
				break;
			case 62:
				if(language==1)
					Say("???","����������, ������, ����������. � �� ����� ������������ �������. ");
				else
					Say("???","More specifically, Andrew, more specifically. I don't like rhetorical questions.");
				break;
			case 63:
				CloseItem(14);
				Shake();
				PlaySound(1);
				PlaySound2(24);
				Move("a","�����",0.6f);
				Mirror("a",new Vector3(1f,1f));
				Move("s","����",0.6f);
				Mirror("s",new Vector3(1f,1f));
				if(language==1)
					Think("���� ������� ����� � ��������� ������. ");
				else
					Think("Another sound of heavy impact and broken glass.");
				break;
			case 64:
				if(language==1)
					Say("???","������� �������, ��� ���� � ������� ��� ������, ���� ����� �����? ");
				else
					Say("???","Do you really think that if I survived the whole clip, the lamp would kill me?");
				break;
			case 65:
				if(language==1)
					Say("a","��� �� ����� �����? ",true);
				else
					Say("a","Who the hell are you?",true);
				break;
			case 66:
				if(language==1)
					Think("��� �� ����� ���� �� ����� ��������, �������� ������ ����� ���������� �� ������ �����. ������ ��� ����� �������, ������� ������� ��� �� ����, ��� ��������� ������������ � ������ ���� ���������, ������ ��� �� ����� ���� �� ����� ����� �� ���� ������. ");
				else
					Think("It doesn't really matter, Sukachev just needs to reach for the second lamp. Andrei is the same person who runs away even before the employee introduces himself and names his position, because in fact he knows the answer to his question.");
				break;
			case 67:
				if(language==1)
					Say("???","�� ������� �� ���� ������ ������, �� ����� �� ������? ");
				else
					Say("???","You worked for me for four months, but you don't know my name?");
				break;
			case 69:
				Move("s","�����",1f,new Vector3(15f,0));
				if(language==1)
					Think("�� ������� �� ����������, ���������� ��� ����� �������� ��� �� ���������� ������. ������� ������� �����-�������� ������� ��� ��������, ����� �������-������� ��������� �������� � �����, �� ����� ��������� ����� ����. ���� ������� �������������, � ������ � ��� ������� ��� � ��������. ");
				else
					Think("But he didn�t manage to escape, Devilry still catches up with him in the stairwell. Andrey's favorite flamingo lamp took him by surprise when the poisonous pink LED crashed on the jamb, a pillar of sparks fell on the mask. One second of confusion, and at that moment Andrei is already in the corridor.");
				break;
			case 68:
				Shake();
				PlaySound(1);
				PlaySound2(24);
				Move("a","�����",1f,new Vector3(15f,0));
				if(language==1)
					Think("���� ��� ����� �������� �����. ");
				else
					Think("The sound of another broken lamp.");
				break;
			case 70:
				Think("");
				BackgroundColoring(Color.black,1f);
				yield return new WaitForSecondsRealtime(1.5f);
				if(language==1)
					Think("���� ����, �� ���� ����� ��������� �� �������� � ������� �� ��� ����, �� � ����� ������ �� ��������� ����� ����� ���������, �� ������� �������� ����. ");
				else
					Think("Not only that, he even managed to get to the stairs and rush down it, but in the end he appears right in front of Sukachev, a dozen steps lower.");
				break;
			case 71:
				if(language==1)
					Say("???","��� ���������, ��� ��� ����������? ");
				else
					Say("???","Should I remind you, or will you guess?");
				break;
			case 72:
				if(language==1)
					Think("��� ���������� ������� ������ ���� ����� �����������, ���������, �� ������ �� ���������� �������. �� ��������� �����������. ���� � �� ��� �� �� �������� � ������ �������� ���������. ");
				else
					Think("His last words were supposed to be �please, Francesca,� but Andrey is not going to beg. Sukachev acts recklessly. The hand - what is left of it - should detain Sukachev.");
				break;
			case 73:
				if(language==1)
					Think("��� �� ���. �� �� �������� ���� ������ ���� ���������, ��� �� ���������� ������ ������ � ��� � ���� ��� ������ ���� �������� ������������� ������. ��������� ���, � ������ ��������� ������ � ��������� ������, �, ������ ��� �� ������� ��� �����, ������������� �� ��������. ");
				else
					Think("This is wrong. He does not even have time to explain to himself what he is going to do next and how crushed fingers should have prevented him from doing this. The next moment, and Andrei rests his back against the low railing, and before he takes a step forward, he pushes himself off the steps.");
				break;
			case 74:
				PlayMusic(12);
				PlaySound(32);
				ColorFade(Color.white,3f);
				yield return new WaitForSecondsRealtime(2f);
				BackgroundUncoloring(0.1f);
				Hide("s");Show("s","�����");
				Hide("a");Show("a","�����");
				Item(9);
				if(language==1)
					Think("��������� ���� ������ ���� �������� ��� ����������� ����� ������, ��... ������ � ����� ��� ������. ����� ��� ������, ����� ��� �������. �������� ����� ��� �������, �� ����� ������, �� ");
				else
					Think("The broken arm was supposed to prevent him from jumping over the railing. But ... Next is almost a jump. Almost a somersault, almost beautiful. Sukachev is almost scared, he almost regrets, but...");
				break;
			case 75:				
				if(language==1)
					Think("��������� �� ������� ������ �������� �� ����������. ������� �� �������� ������, ��� ��� � ��� ������, ����� ������������, ��� ��������� �� �����, �� ��� ���, � �������. ���� �� ���������, ������ ������� ������� ��� ��� ��� ������ ������� ���� � ���� � ������ �� �������� ������. � ���� ������ �� ��� ������ ���� ����. ");
				else
					Think("Francesca is left lying broken on the steps. In time, he disengaged his fingers, just at the moment when he felt himself lift off the ground, this time, with the ends. He saved Francesca, broke the devil's toy, or is this his way of spitting in God's face - Andrei does not have time to decide. At this point, he should already be dead.");
				break;
			case 76:
				if(language==1)
					Think("��, � ���������, ����� ���� ��� ������������ �������, ���, ����� ���������� ��������. ��������� ������ �������, ���������� ����� �������, ���������� � ������� �� ������������, ������� ������� � ������������ ������. ");
				else
					Think("But, unfortunately, before that he was pursued by dozens, no, hundreds of flights of stairs. They multiplied every second, flickering before my eyes, woven into a web of rusted, forged rods and peeling paint.");
				break;
			case 77:
				if(language==1)
					Say("a","�� ������� � ������ ����, ����� ������� � ������ �����?");
				else
					Say("a","There must be so many of them when you fall from the fifth floor?");
				break;
			case 78:
				PlaySound(27);
				if(language==1)
					Think("������ ���������. �����������, ��� ���� ����� �� ������ �� ������ �� ���������� �� ���������, ���� �� �������, ��� �����������, ����� �� ������ �� ���������� ��� ������ ��������, � ��� �� ��������� �� � ���. ");
				else
					Think("Andrei smiled. It turns out that all his life before the jump, he really did not hate anyone, because the feeling that you experience when you no longer feel the steps under your feet is incomparable to anything.");
				break;
			case 80:
				if(language==1)
					Think("������ ������ ������� ��������. �� ����� ���� �� ����� �� ������ ������, ����� �� ��� ����� ������. ");
				else
					Think("Andrey was just a little, just a little, offended, and so ... He loves until he loses his pulse, he is ready to give his life for them.");
				break;
			case 79:
				if(language==1)
					Think("��� ������ �� ����? ��������� � ����? ����� �� ����? ������� �����, ��������� ��� � �����, ������. ");
				else
					Think("His anger at Fedya? Contempt for Zhenya? Resentment against Sanya? Baby talk, the latter is completely funny.");
				break;
			case 81:
				if(language==1)
					Think("��� ����� �� �������� �� ���������? �� ���� ���� �������� ��������� � ������, �� ���� �� ������� �� ����� ���� �� �����. ");
				else
					Think("And what did he take for hate? Drugs and weed are to blame for all this, but even Andryusha doesn�t really blame them.");
				break;
			case 82:
				if(language==1)
					Think("��-����������, �� ������ ����� �������, �� ������ ����, �� ����, �� ���������� ������� � ����� � ��� ����� � �������, ��� ��� ������� �� ��� ������, �������� ������ ���� ������ � ����� ��������������� �� ������ ���� � ���������.");
				else
					Think("For real, to the veil before the eyes, to the white noise, to the absence of air in the lungs in the place in the selection where the script was written for this, there was only one simple and capacious noun of nine letters - hatred.");
				break;
			case 83:
				if(language==1)
					Think("������� ���������. ���������, ���������, ���������, �� �����, ��������� ���� �� ������. ���� �� ���� ������� �������, ���� ���� ������, ����, �����");
				else
					Think("Sukachev hates. Hates, hates, hates, he fucking hates himself for jumping. After all, there were no problems, there was one fucking, bitch, a whim");
				break;
			case 84:
				if(language==1)
					Think("�� ����� �������� ������, ��� ������� �� ����� �� ������, � �� ����� ���������� �����. ��������� ����� ��������, � ������ ������������ �� ������� �������� ������� ����� ����������. ");
				else
					Think("But as soon as Sukhachev realizes that he has been falling for too long, he becomes himself again. The idiotic ardor fades, and instead of the pink picture he painted, Sukachev sees reality.");
				break;
			case 85:
				if(language==1)
					Think("������� ����������, ������ �� �������.");
				else
					Think("Sukachev remembers why he jumped.");
				break;
			case 86:
				PlaySound(32);
				ColorFade(Color.white,3f);
				yield return new WaitForSecondsRealtime(2f);
				CloseItem(9);			
				NextCoroutine("A1",0);
				break;
			
		}
		yield return new WaitForEndOfFrame();
		st.CoroutineEnding();
	}
}
