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
				yield return StartCoroutine(act.FadeDown("<color=red>Внимание!</color>\r\nВсе персонажи и описываемые события являются вымышленными.\r\nЛюбое совпадение с реальными людьми или событиями,является случайностью.\r\nДанная игра содержит в себе резкие моменты,вспышки,сцены насилия и нецензурные выражения.\r\nДанная игра не является пропагандой наркотиков,суицида или чего то другого.\r\n<color=red>Не рекомендуется лицам,не достигшим 18 лет,со слабой психикой или эпилепсией.</color> ",3f));
				if(language==1)
					Say("sh","Помнишь, ты спрашивал, как у меня дела? ");

				else
					Say("sh","Remember when you asked me how I was doing?");
				break;
			case 2:								
				if(language==1)
					Say("sh","Я не помню, когда это было или что я там тебе отвечала");

				else
					Say("sh","I don't remember when it was or what I answered you there.");
				break;
			case 3:						
				if(language==1)
					Say("sh","Да и не важно это");

				else
					Say("sh","Yes, and it doesn't matter");
				break;
			case 4:								
				if(language==1)
					Say("sh","Отвечу ещё раз");

				else
					Say("sh","I will answer again");
				break;
			case 5:			
				if(language==1)
					Say("sh","Я не думаю, что все ок. ");

				else
					Say("sh","I don't think everything is ok.");
				break;
			case 6:				
				Fade();
				yield return new WaitForSecondsRealtime(2f);
				Scene(0);
				SecondScene(0);
				if(language==1)
					Think("Зелёный огонёк, оповещающий об онлайне, потухает, а Сукачев как ни в чём не бывало наводит курсор на синенькую стрелочку, возвращаясь к списку диалогов. Пальцы,сжимающие мышку,подрагивают.Но дело не в нервах.Дело,как всегда,в дури.");
				else
					Think("The green light, announcing online, goes out, and Sukachev, as if nothing had happened, points the cursor at the blue arrow, returning to the list of dialogues.The fingers squeezing the mouse tremble.But it's not the nerves. The thing is, as always, dope.");
				break;
			case 7:
				if(language==1)
					Say("a","В этот раз даже до полуночи не дотянула.");
				else
					Say("a","Didn't even make it to midnight this time.");
				break;
			case 9:
				PlaySound(3);
				if(language==1)
					Say("a","Вот серьезно, Женёк, ты не группис, а пустая трата заряда на моей Франческе! ");
				else
					Say("a","Seriously, Zhenya, you are not a groupie, but a waste of charge on my Francesca!");
				break;
			case 8:
				if(language==1)
					Say("a","Нужно было закинуть её в блок к Феде");
				else
					Say("a","It was necessary to throw her in the block to Fedya");
				break;
			case 10:				
				PlaySound(0);
				Messenger(6,0);
				if(language==1)
					Say("АНДРЮША СУКАЧЕВ","Да приду я, приду, заебала");
				else
					Say("ANDRYUSHA SUKACHEV","Yes, I'll come, I'll come, fucked up.");
				break;
			case 11:
				PlaySound(0);
				Messenger(6,1);
				PlaySound2(5);
				if(language==1)
					Say("АНДРЮША СУКАЧЕВ","Скручу ещё один косячок, и сразу к тебе ");
				else
					Say("ANDRYUSHA SUKACHEV","I'll twist another joint, and immediately to you.");
				break;
			case 12:
				PlaySound(0);
				Messenger(6,2);
				if(language==1)
					Say("АНДРЮША СУКАЧЕВ","Ну ты это, смотри там, не разлагайся, запах пиздец какой стоит после этого");
				else
					Say("ANDRYUSHA SUKACHEV","Well, you are, look there, do not decompose, what a fucking smell after that.");
				break;
			case 13:
				PlaySound(0);
				Messenger(6,3);
				if(language==1)
					Say("АНДРЮША СУКАЧЕВ","Так что будь хорошей девочкой и дождись меня");
				else
					Say("ANDRYUSHA SUKACHEV","So be a good girl and wait for me.");
				break;
			case 14:
				PlaySound(0);
				Messenger(6,4);
				if(language==1)
					Say("АНДРЮША СУКАЧЕВ","Окей? Но если и в этот раз не получится, то дальше ты как нибудь сама, окей, Женёк?");
				else
					Say("ANDRYUSHA SUKACHEV","OK? But if this time it doesn’t work out, then you’ll somehow go on your own, okay, Zhenya?");
				break;
			case 15:
				PlaySound(0);
				Messenger(6,5);
				if(language==1)
					Say("АНДРЮША СУКАЧЕВ","Ну сама подумай. Это ведь даже не блок, я от тебя не отказываюсь, а даю тебе ещё один шанс");
				else
					Say("ANDRYUSHA SUKACHEV","Well, think for yourself. It's not even a block, I'm not giving up on you, but giving you one more chance.");
				break;
			case 16:
				PlaySound(0);
				Messenger(6,6);
				if(language==1)
					Say("АНДРЮША СУКАЧЕВ","Ну разве я не хороший? ");
				else
					Say("ANDRYUSHA SUKACHEV","Well, am I not good?");
				break;
			case 17:
				PlaySound(0);
				Messenger(6,7);
				if(language==1)
					Say("АНДРЮША СУКАЧЕВ","Самый лучший, я самый лучший! ");
				else
					Say("ANDRYUSHA SUKACHEV","The best, I'm the best!");
				break;
			case 18:
				PlaySound(0);
				Messenger(6,8);
				if(language==1)
					Say("АНДРЮША СУКАЧЕВ","И всё для тебя одной, Федя-то в блоке. ");
				else
					Say("ANDRYUSHA SUKACHEV","And all for you alone, Fedya is in the block.");
				break;
			case 19:
				yield return StartCoroutine(act.Glitch(12,true));
				if(language==1)
					Say("a","Или для тебя это…");
				else
					Say("a","Or is it for you...");
				break;
			case 20:
				if(language==1)
					Say("a","Как ты там говорила? ");
				else
					Say("a","How did you say it?");
				break;
			case 21:
				if(language==1)
					Say("a","«Не окей»? ");
				else
					Say("a","\"Not okay\"?");
				break;
			case 22:
				if(language==1)
					Say("a","Ну так не бывает оно «окей»");
				else
					Say("a","Well, it doesn’t happen that way, “okay”");
				break;
			case 23:
				if(language==1)
					Say("a","Ты просто нажимаешь на кнопочку и делаешь вот так…");
				else
					Say("a","You just press a button and do this...");
				break;
			case 24:
				if(language==1)
					Think("Андрей чувствует, как плеер упирается в висок, и отработанным движением возводит курок. ");
				else
					Think("Andrey feels how the player rests on his temple, and with a practiced movement he raises the trigger.");
				break;
			case 25:
				if(language==1)
					Think("Теперь, когда рычажок красуется рядом с полустертым «вкл», остаётся только ввести время и нажать плеей, но Андрей вместо этого тянется к пепельнице. Дуло все ещё упирается в висок, да так плотно, что вдави сильнее, и на зелёную пластмассу брызнут гнилые Андрюшины мозги.");
				else
					Think("Now, when the lever flaunts next to the half-erased \"on\", all that remains is to enter the time and press the play, but Andrei instead reaches for the ashtray. The muzzle still rests against the temple, so tightly that you push harder, and Andryushin's rotten brains will splatter on the green plastic.");
				break;
			case 26:
				if(language==1)
					Think("Пепельница стоит так, что мгновение, и вместо окурка в ней оказывался блант. Андрей так балуется с тех самых пор самых пор, как стало не до закладок. С первого четверга месяца, получается? ");
				else
					Think("The ashtray stands in such a way that a moment, and instead of a cigarette butt, it turned out to be a blunt. Andrey has been playing around like that ever since, since there was no time for bookmarks. From the first Thursday of the month, right?");
				break;
			case 27:
				if(language==1)
					Think("Андрей затягивается: глаза уже слезятся от дыма, пальцы, сжимающие Франческу, немеют, но сам он только зажмурился от блаженства, наслаждаясь добавленными в фонд «до следующего скачка» секундами. ");
				else
					Think("Andrey takes a puff: his eyes are already watering from the smoke, the fingers squeezing Francesca are going numb, but he himself only closed his eyes in bliss, enjoying the seconds added to the fund “until the next jump”.");
				break;
			case 28:
				if(language==1)
					Think("Интервалы сокращаются, а разобранных на детали игрушек всё больше, они уже едва помещаются на столе — наполнитель для мягких игрушек облепляет пластмассу, а между ними шнурки и цепи, ткань, патроны. ");
				else
					Think("The intervals are shortening, and there are more and more toys disassembled into parts, they can barely fit on the table - the filler for soft toys clings to the plastic, and between them there are laces and chains, fabric, cartridges.");
				break;
			case 29:
				if(language==1)
					Think("К могильнику Франческа не имеет никакого отношения, это личное. ");
				else
					Think("Francesca has nothing to do with the burial ground, this is personal.");
				break;
			case 30:
				if(language==1)
					Think("Андрей сгребает их в сторону, не задумываясь, дальше от святая-святых — батареек. Но всё так же не опускает свою Франческу. ");
				else
					Think("Andrey rakes them aside, without hesitation, further from the holy of holies - batteries. But still does not lower his Francesca.");
				break;
			case 31:
				if(language==1)
					Think("Странная штука, этот фонд. Андрей часами калибрует Франческу, настраивает скрипты, ищет способ в несколько кликов абьюзить как можно большее число задач, и это не считается.");
				else
					Think("Strange thing, this fund. Andrei spends hours calibrating Francesca, setting up scripts, looking for a way to abuse as many tasks as possible in a few clicks, and this does not count.");
				break;
			case 32:
				if(language==1)
					Think("Но вот посидеть пять минут в своём времени, пока заходит в чат-бот, и палец сразу же тянется нажать на плей…");
				else
					Think("But to sit for five minutes in your own time, while he enters the chat bot, and the finger immediately reaches out to click on the play ...");
				break;
			case 33:
				yield return StartCoroutine(act.Glitch(0));
				Show("a","Центр");
				StartDissolve("a",0);
				if(language==1)
					Think("Прямо как сейчас: он, так и не докурив, бросает остатки обратно в пепельницу и щёлкает по красному треугольнику… Но мир остаётся на месте. ");
				else
					Think("Just like now: he, without finishing his cigarette, throws the rest back into the ashtray and clicks on the red triangle ... But the world remains in place.");
				break;
			case 34:
				if(language==1)
					Think("Андрей на это не реагирует. Следит, прикрыв глаза, как свет от монитора играет на сколах, подсвечивает следы пальцев на пыльном и грязном стекле, и вводит координаты ещё раз. Такое случилось с Андреем впервые, но он как ни в чем не бывало перебивает настройки и снова запускает Франческу… ");
				else
					Think("Andrey does not respond to this. Covering his eyes, he watches how the light from the monitor plays on the chips, highlights the fingerprints on the dusty and dirty glass, and enters the coordinates again. This happened to Andrey for the first time, but he, as if nothing had happened, interrupts the settings and launches Francesca again ...");
				break;
			case 35:
				if(language==1)
					Think("Но ничего не происходит. ");
				else
					Think("But nothing happens.");
				break;
			case 36:
				PlaySound(29);
				if(language==1)
					Think("Слышится глухой щелчок, и на этом всё. Мир остаётся на месте. Пепельница остаётся на месте. ");
				else
					Think("A dull click is heard, and that's it. The world remains in place. The ashtray remains in place.");
				break;
			case 37:				
				if(language==1)
					Think("Андрея и эта осечка не слишком беспокоит, его на самом деле весь мир беспокоит не так чтобы слишком уж сильно, он просто перезагружает Франческу и снова стреляет, всё в тот же висок. ");
				else
					Think("Andrey is not too worried about this misfire, in fact, the whole world does not bother him too much, he just reloads Francesca and shoots again, all at the same temple.");
				break;
			case 38:
				PlaySoundMultTimes(29,2);
				if(language==1)
					Think("Щелчок. Тишина. Ещё раз. ");
				else
					Think("Click. Silence. Again.");
				break;
			case 39:
				PlaySoundMultTimes(29,3);
				if(language==1)
					Think("Щелчок. Тишина. Ещё раз. ");
				else
					Think("Click. Silence. Again.");
				break;
			case 40:
				Thrill("a");
				PlaySound2MultTimes(29,15);
				if(language==1)
					Think(RichText("<shake>Щелчок, щелчок, щелчок, щелчок, щелчок щелчок, щелчок, щелчок, Щелчок.</shake> ",Color.red));
				else
					Think(RichText("Click, click, click, click, click click, click, click, click.",Color.red));
				break;
			case 41:
				if(language==1)
					Think(RichText("<shake a=3>ТИШИНА</shake>",Color.red));
				else
					Think(RichText("SILENCE.",Color.red));
				break;
			case 42:				
				PlaySound(27);
				Dissolve("a",1);
				if(language==1)
					Say("a","*смеётся*");
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
					Think("Звук летящей со стола пепельницы, разбитого стекла, ударов по столу. ");
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
					Think("Стук в дверь. ");
				else
					Think("Knock on the door.");
				break;
			case 45:
				PlaySoundMultTimes(29,3);
				if(language==1)
					Think("Андрей ещё раз кликает на плей. Его Франческа —  единственная целая вещь в комнате.");
				else
					Think("Andrey once again clicks on the play. His Francesca is the only whole thing in the room.");
				break;
			case 46:
				if(language==1)
					Think("И голова, торчащая из двери.");
				else
					Think("And a head sticking out of the door.");
				break;
			case 47:
				Move("a","Лево",0.5f);
				Mirror("a",new Vector3(-1f,1f));
				Show("s","Право",new Vector3(-1f,1f));
				StartDissolveWithColor("s",0,Color.black);
				if(language==1)
					Say("???","Доигрался, я так понимаю? ");
				else
					Say("???","Finished, I understand?");
				break;
			case 48:
				if(language==1)
					Say("???","Я, если честно, уже заебался тебя ждать, Сукачев. ");
				else
					Say("???","To be honest, I'm already tired of waiting for you, Sukachev.");
				break;
			case 49:
				Dissolve("a",2);
				if(language==1)
					Think("Нет, это враньё. Франческа не единственная, у Андрея есть ещё его любимый пистолет. Единственное, что кроме неё осталось нетронутым. А остальное? ");
				else
					Think("No, this is a lie. Francesca is not the only one, Andrei also has his favorite pistol. The only thing that remained untouched besides her. But other?");
				break;
			case 50:
				if(language==1)
					Think("Перевернутый разбитый монитор компьютера, бесполезная груда металлолома окружает сгорбившегося на полу Андрея. Заляпанные кровью батарейки. Битое стекло, окурки, пепел, от всего этого несёт сыростью и железом. Рука неестественно выгнута, её совсем нехорошо трясёт. ");
				else
					Think("An overturned broken computer monitor, a useless pile of scrap metal surrounds Andrey hunched on the floor. Batteries covered in blood. Broken glass, cigarette butts, ashes, from all this carries dampness and iron. The hand is unnaturally arched, it is not shaking at all well.");
				break;
			case 51:
				if(language==1)
					Think("Всё, что ниже локтя, — одно сплошное месиво из крови, мяса и того, что напоминает кости, но Сукачеву всё равно. Он в ободранных пальцах сжимает целый и невидимый, отжатый у инкассатора ствол. То, что осталось от правой руки, кажется мёртвым грузом, и его только в расход —  отрезать по плечевой сустав, пока не начало гнить.");
				else
					Think("Everything below the elbow is one continuous mess of blood, meat and what looks like bones, but Sukachev doesn’t care. He is squeezing in his peeled fingers a whole and invisible barrel squeezed from the collector. What is left of the right arm seems to be a dead weight, and it is only for consumption - cut off at the shoulder joint until it starts to rot.");
				break;
			case 52:
				if(language==1)
					Think("Дуло ходит ходуном, Сукачев никак не может прицелиться. Там, где должна быть цель, у него расплывается нехорошее черное пятно. Когда звон в ушах становится невыносимым и не остаётся ничего, кроме стрекочущей, неутихающей ни на мгновенье темноты, Сукачев стреляет. ");
				else
					Think("The muzzle shakes, Sukachev can't aim. Where there should be a target, he has a bad black spot. When the ringing in the ears becomes unbearable and there is nothing left but a chirring, unceasing darkness for a moment, Sukachev shoots.");
				break;
			case 53:
				EndDissolve("a");
				EndDissolve("s");
				GunFire(2,1f); 
				if(language==1)
					Think("ВЫСТРЕЛ. ПЕРЕЗАРЯДКА. "+RichText("<shake>ЕЩЕ ОДИН.</shake>",Color.red));
				else
					Think("SHOT. RECHARGE. "+RichText("<shake>ANOTHER ONE.</shake>",Color.red));
				break;
			case 54:
				GunFire(10,0.5f);
				if(language==1)
					Think(RichText("<shake a=5>И ЕЩЁ. И ЕЩЁ. ЕЩЁ, ЕЩЁ, ЕЩЁ. </shake>",Color.red));
				else
					Think(RichText("<shake a=5>AND FURTHER. AND FURTHER. MORE MORE MORE.</shake>",Color.red));
				break;
			case 55:
				if(language==1)
					Think("Вся обойма в двери, а белая маска всё ещё единственное, что он перед собой видит.А если бы план Андрея сработал,остались бы только гильзы и кровь.Нет,не только кровь и гильзы,Сухачев,очнись,от мёртвых остаются тела и что ты будешь делать со ста пятьюдесятью фунтами гнилого мяса ?");
				else
					Think("The entire clip is in the door, and the white mask is still the only thing he sees in front of him.And if Andrey's plan had worked, only shell casings and blood would have remained.No, not only blood and shell casings, Sukhachev, wake up, bodies remain from the dead, and what are you going to do with one hundred and fifty pounds of rotten meat?");
				break;
			case 56:				
				StartDissolve("a",0);
				if(language==1)
					Say("a","Почему ты сейчас…?");
				else
					Say("a","Why are you now...?");
				break;
			case 57:
				if(language==1)
					Think("Спрашивает у Франчески, но отвечает ему не она.");
				else
					Think("He asks Francesca, but she does not answer him.");
				break;
			case 58:				
				StartDissolveWithColor("s",0,Color.black);
				if(language==1)
					Say("???","«Почему я сейчас» что? ");
				else
					Say("???","\"Why me now\" what?");
				break;
			case 59:
				if(language==1)
					Say("???","Взломал твой электронный замок? ");
				else
					Say("???","Cracked your electronic lock?");
				break;
			case 60:
				if(language==1)
					Say("???","Отключил сигнализацию? ");
				else
					Say("???","Turned off the alarm?");
				break;
			case 61:
				if(language==1)
					Say("???","Заглянул в твою святая святых?");
				else
					Say("???","Looked into your holy of holies?");
				break;
			case 62:
				if(language==1)
					Say("???","Конкретнее, Андрей, конкретнее. Я не люблю риторические вопросы. ");
				else
					Say("???","More specifically, Andrew, more specifically. I don't like rhetorical questions.");
				break;
			case 63:
				CloseItem(14);
				Shake();
				PlaySound(1);
				PlaySound2(24);
				Move("a","Право",0.6f);
				Mirror("a",new Vector3(1f,1f));
				Move("s","Лево",0.6f);
				Mirror("s",new Vector3(1f,1f));
				if(language==1)
					Think("Звук тяжёлого удара и разбитого стекла. ");
				else
					Think("Another sound of heavy impact and broken glass.");
				break;
			case 64:
				if(language==1)
					Say("???","Неужели думаешь, что если я пережил всю обойму, меня убьёт лампа? ");
				else
					Say("???","Do you really think that if I survived the whole clip, the lamp would kill me?");
				break;
			case 65:
				if(language==1)
					Say("a","Кто ты блядь такой? ",true);
				else
					Say("a","Who the hell are you?",true);
				break;
			case 66:
				if(language==1)
					Think("Это на самом деле не имеет значения, Сукачеву просто нужно дотянуться до второй лампы. Андрей тот самый человек, который убегает ещё до того, как сотрудник представится и назовёт свою должность, потому что на самом деле он знает ответ на свой вопрос. ");
				else
					Think("It doesn't really matter, Sukachev just needs to reach for the second lamp. Andrei is the same person who runs away even before the employee introduces himself and names his position, because in fact he knows the answer to his question.");
				break;
			case 67:
				if(language==1)
					Say("???","Ты работал на меня четыре месяца, но имени не знаешь? ");
				else
					Say("???","You worked for me for four months, but you don't know my name?");
				break;
			case 69:
				Move("s","Право",1f,new Vector3(15f,0));
				if(language==1)
					Think("Но убежать не получилось, Чертовщина все равно догоняет его на лестничной клетке. Любимая Андреем лампа-фламинго застала его врасплох, когда ядовито-розовый светодиод разбился о косяк, на маску обрушился столп искр. Одна секунда растерянности, а Андрей в эту секунду уже в коридоре. ");
				else
					Think("But he didn’t manage to escape, Devilry still catches up with him in the stairwell. Andrey's favorite flamingo lamp took him by surprise when the poisonous pink LED crashed on the jamb, a pillar of sparks fell on the mask. One second of confusion, and at that moment Andrei is already in the corridor.");
				break;
			case 68:
				Shake();
				PlaySound(1);
				PlaySound2(24);
				Move("a","Право",1f,new Vector3(15f,0));
				if(language==1)
					Think("Звук ещё одной разбитой лампы. ");
				else
					Think("The sound of another broken lamp.");
				break;
			case 70:
				Think("");
				BackgroundColoring(Color.black,1f);
				yield return new WaitForSecondsRealtime(1.5f);
				if(language==1)
					Think("Мало того, он даже сумел добраться до лестницы и рвануть по ней вниз, но в конце концов он возникает прямо перед Сукачевым, на десяток ступеней ниже. ");
				else
					Think("Not only that, he even managed to get to the stairs and rush down it, but in the end he appears right in front of Sukachev, a dozen steps lower.");
				break;
			case 71:
				if(language==1)
					Say("???","Мне напомнить, или сам догадаешся? ");
				else
					Say("???","Should I remind you, or will you guess?");
				break;
			case 72:
				if(language==1)
					Think("Его последними словами должны были стать «пожайлуста, Франческа», но Андрей не собирается умолять. Он действует безрассудно. Рука — то что от неё осталось — должна Сукачева задержать. ");
				else
					Think("His last words were supposed to be “please, Francesca,” but Andrey is not going to beg. Sukachev acts recklessly. The hand - what is left of it - should detain Sukachev.");
				break;
			case 73:
				if(language==1)
					Think("Это не так. Он не успевает даже самому себя объяснить, что он собирается делать дальше и как в этом ему должны были помешать раздробленные пальцы. Следующий миг, и Андрей упирается спиной в невысокие перила, и, прежде чем он сделает шаг вперёд, отталкивается от ступенек. ");
				else
					Think("This is wrong. He does not even have time to explain to himself what he is going to do next and how crushed fingers should have prevented him from doing this. The next moment, and Andrei rests his back against the low railing, and before he takes a step forward, he pushes himself off the steps.");
				break;
			case 74:
				PlayMusic(12);
				PlaySound(32);
				ColorFade(Color.white,3f);
				yield return new WaitForSecondsRealtime(2f);
				BackgroundUncoloring(0.1f);
				Hide("s");Show("s","Центр");
				Hide("a");Show("a","Центр");
				Item(9);
				if(language==1)
					Think("Сломанная рука должна была помешать ему перемахнуть через перила, но... Дальше — почти что прыжок. Почти что сальто, почти что красиво. Сукачеву почти что страшно, он почти жалеет, но… ");
				else
					Think("The broken arm was supposed to prevent him from jumping over the railing. But ... Next is almost a jump. Almost a somersault, almost beautiful. Sukachev is almost scared, he almost regrets, but...");
				break;
			case 75:				
				if(language==1)
					Think("Франческа же остаётся лежать разбитой на ступеньках. Вовремя он расцепил пальцы, как раз в тот момент, когда почувствовал, как отрывался от земли, на сей раз, с концами. Спас он Франческу, разбил игрушку дьявола или это его способ плюнуть богу в лицо — Андрей не успевает решить. В этот момент он уже должен быть мёртв. ");
				else
					Think("Francesca is left lying broken on the steps. In time, he disengaged his fingers, just at the moment when he felt himself lift off the ground, this time, with the ends. He saved Francesca, broke the devil's toy, or is this his way of spitting in God's face - Andrei does not have time to decide. At this point, he should already be dead.");
				break;
			case 76:
				if(language==1)
					Think("Но, к сожалению, перед этим его преследовали десятки, нет, сотни лестничных пролетов. Множились каждую секунду, мельтешили перед глазами, сплетались в паутину из проржавевших, кованых прутьев и облупившейся краски. ");
				else
					Think("But, unfortunately, before that he was pursued by dozens, no, hundreds of flights of stairs. They multiplied every second, flickering before my eyes, woven into a web of rusted, forged rods and peeling paint.");
				break;
			case 77:
				if(language==1)
					Say("a","Их столько и должно быть, когда падаешь с пятого этажа?");
				else
					Say("a","There must be so many of them when you fall from the fifth floor?");
				break;
			case 78:
				PlaySound(27);
				if(language==1)
					Think("Андрей улыбается. Оказывается, всю свою жизнь до прыжка он никого по настоящему не ненавидел, ведь то чувство, что испытываешь, когда ты больше не чувствуешь под ногами ступенек, — оно не сравнится ни с чем. ");
				else
					Think("Andrei smiled. It turns out that all his life before the jump, he really did not hate anyone, because the feeling that you experience when you no longer feel the steps under your feet is incomparable to anything.");
				break;
			case 80:
				if(language==1)
					Think("Андрей просто немного обиделся. На самом деле он любит до потери пульса, жизнь за них готов отдать. ");
				else
					Think("Andrey was just a little, just a little, offended, and so ... He loves until he loses his pulse, he is ready to give his life for them.");
				break;
			case 79:
				if(language==1)
					Think("Его злость на Федю? Презрение к Жене? Обида на Саню? Детский лепет, последнее так и вовсе, смешно. ");
				else
					Think("His anger at Fedya? Contempt for Zhenya? Resentment against Sanya? Baby talk, the latter is completely funny.");
				break;
			case 81:
				if(language==1)
					Think("Что тогда он принимал за ненависть? Во всем этом виноваты наркотики и травка, но даже их Андрюша на самом деле не винит. ");
				else
					Think("And what did he take for hate? Drugs and weed are to blame for all this, but even Andryusha doesn’t really blame them.");
				break;
			case 82:
				if(language==1)
					Think("По-настоящему, до пелены перед глазами, до белого шума, до того, до отсутствия воздуха в лёгких в том месте в подборе, где был записан на это скрипт, осталось только одно просто и емкое существительное из девяти букв — ненависть.");
				else
					Think("For real, to the veil before the eyes, to the white noise, to the absence of air in the lungs in the place in the selection where the script was written for this, there was only one simple and capacious noun of nine letters - hatred.");
				break;
			case 83:
				if(language==1)
					Think("Сукачев ненавидит. Ненавидит, ненавидит, ненавидит, он блять, ненавидит себя за прыжок. Ведь не было никаких проблем, была одна ебаная, сука, блажь");
				else
					Think("Sukachev hates. Hates, hates, hates, he fucking hates himself for jumping. After all, there were no problems, there was one fucking, bitch, a whim");
				break;
			case 84:
				if(language==1)
					Think("Но стоит Сухачеву понять, что слишком уж долго он падает, и он снова становится собой. Идиотский азарт затухает, и вместо нарисованной им розовой картинки Сукачев видит реальность. ");
				else
					Think("But as soon as Sukhachev realizes that he has been falling for too long, he becomes himself again. The idiotic ardor fades, and instead of the pink picture he painted, Sukachev sees reality.");
				break;
			case 85:
				if(language==1)
					Think("Сукачев вспоминает, почему он прыгнул.");
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
