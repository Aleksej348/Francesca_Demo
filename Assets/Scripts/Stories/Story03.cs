using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Story03 : Story
{
	private IEnumerator E1A1B1()
	{
		st.CoroutineBegining();
		switch(st.step)
		{
			case 0:
			TimeTravel("Квартира Андрея: Компьютерный стол\r\n2020", 0, 0);
			yield return new WaitForSecondsRealtime(12f/speed);
			break;
			case 1:
			SetAllButtons(true);
			Item(8);
			if(language==1)
				Think("27.11.2020");
			else
				Think("27.11.2020");
			break;
			case 2:
			if(language==1)
				Think("То, что Сукачев вернулся в свою комнату, он замечает не сразу —");
			else
				Think("The fact that Sukachev returned to his room, he notices not immediately —");
			break;
			case 3:
			if(language==1)
				Think("Вначале — рвётся в коридор, едва не снеся с петель дверь. Потом — чуть не сносит ещё одну, входную, громко ею хлопая, надеясь оставить всё позади… ");
			else
				Think("At the beginning, he rushes into the corridor, almost knocking the door off its hinges. Then - he almost blows another one, the entrance, loudly clapping it, hoping to leave everything behind ... ");
			break;
			case 4:
			if(language==1)
				Think("Всё — громкие разборки, засранную квартиру, двух наркоманок…");
			else
				Think("Everything - loud fights, a dirty apartment, two drug addicts…");
			break;
			case 5:
			if(language==1)
				Think("Но, ухватившись за ручку, останавливается. ");
			else
				Think("But, grabbing the handle, he stops. ");
			break;
			case 6:
			if(language==1)
				Think("Ручка — новенькая, свежая, совсем недавно установленная мастером. На ней его мертвенно бледные пальцы, компульсивно сжимающие имитацию под металл, выглядят, конечно, дико. ");
			else
				Think("The pen is brand new, fresh, just recently installed by the master. On it, his deathly pale fingers, compulsively squeezing the metal-like imitation, look, of course, wild. ");
			break;
			case 7:
			if(language==1)
				Think("Но");
			else
				Think("But");
			break;
			case 8:
			Show("a", "Центр");
			StartDissolve("a", 0);
			if(language==1)
				Say("a", "Но, но, но, но! ");
			else
				Say("a", "But, but, but, but! ");
			break;
			case 9:
			if(language==1)
				Say("a", "Руки, как у героинщика…", true);
			else
				Say("a", "Hands like a heroin addict…", true);
			break;
			case 10:
			PlaySound(10);
			if(language==1)
				Think("Андрей, дышащий, как загнанная до полусмерти лошадь, старается не съедать окончания и не подавиться насмерть вязкой, раздражающе холодными и грозящими забить лёгкие слезами. ");
			else
				Think("Andrey, breathing like a half-dead horse, tries not to eat the endings and not to choke to death with viscous, annoyingly cold tears that threaten to fill his lungs. ");
			break;
			case 11:
			PlaySound(8);
			if(language==1)
				Think("И продолжает, пытаясь вместе с тем отдышаться —");
			else
				Think("And continues, at the same time trying to catch his breath —");
			break;
			case 12:
			if(language==1)
				Say("a", " Но дело-то не в них…", true);
			else
				Say("a", " But it's not about them…", true);
			break;
			case 13:
			if(language==1)
				Say("a", "Нет.");
			else
				Say("a", "No.");
			break;
			case 14:
			if(language==1)
				Say("a", "Тишина!");
			else
				Say("a", "Silence!");
			break;
			case 15:
			if(language==1)
				Say("a", "Тут тихо! ");
			else
				Say("a", "It's quiet here! ");
			break;
			case 16:
			if(language==1)
				Say("a", "И ручка родная!");
			else
				Say("a", "And the pen is dear!");
			break;
			case 17:
			PlaySound(4);
			Dissolve("a", 1);
			if(language==1)
				Say("a", "*смеётся*");
			else
				Say("a", "*laughs*");
			break;
			case 18:
			if(language==1)
				Say("a", "Повезло тебе, Андрюша.");
			else
				Say("a", "Lucky you, Andryusha.");
			break;
			case 19:
			if(language==1)
				Say("a", "Ой как повезло.");
			else
				Say("a", "Oh, how lucky.");
			break;
			case 20:
			if(language==1)
				Think("Андрей, всё смеясь, возвращается как ни в чем не бывало назад, в свою комнату. ");
			else
				Think("Andrey, still laughing, returns as if nothing had happened back to his room. ");
			break;
			case 21:
			Dissolve("a", 0);
			if(language==1)
				Think("Побледневший, с дикими глазами, руками, всё ещё сжатыми в кулаки, и побелевшими костяшками — не разжать. ");
			else
				Think(" Pale, with wild eyes, hands still clenched into fists, and white knuckles - can not be unclenched. ");
			break;
			case 22:
			if(language==1)
				Think("Да оно и не надо, плееру всё равно — пластмасса на удивление крепкая. ");
			else
				Think("Yes, it is not necessary, the player does not care - the plastic is surprisingly strong. ");
			break;
			case 23:
			if(language==1)
				Say("a", "А ты и дальше морозься, на здоровье.");
			else
				Say("a", "And you continue to freeze, to your health.");
			break;
			case 24:
			Move("a", "Центр", "Право", 1f);
			Show("aa", "Центр", new Vector3(-1f, 1f, 0));
			StartDissolve("aa", 0);
			Move("aa", "Центр", "Лево", 1f);
			yield return new WaitForSecondsRealtime(1f/speed);
			if(language==1)
				Say("aa", "Зачем мне это — мозг же у нас один на двоих, и он одинаково сгнил.", true);
			else
				Say("aa", "Why do I need this - we have one brain for two, and it rotted equally.", true);
			break;
			case 25:
			if(language==1)
				Say("aa", "Обнуляется только в путь.");
			else
				Say("aa", "Reset to zero only on the way.");
			break;
			case 26:
			if(language==1)
				Say("aa", "Наркоманы, сэр.");
			else
				Say("aa", "Junkies, sir.");
			break;
			case 27:
			Dissolve("aa", 1);
			PlaySound(4, 0.8f);
			if(language==1)
				Say("aa", "*смеётся*");
			else
				Say("aa", "*laughs*");
			break;
			case 28:
			if(language==1)
				Say("aa", "НАРКОМАНЫ!!", true);
			else
				Say("aa", "DRUGS!", true);
			break;
			case 29:
			Move("a", "Право", "Центр", 1f);
			Move("aa", "Лево", "Центр", 1f);
			EndDissolve("aa");
			if(language==1)
				Think("Андрей его не слышит.");
			else
				Think("Andrey can't hear him.");
			break;
			case 30:
			if(language==1)
				Think("Его не задело.");
			else
				Think("He didn't get hurt.");
			break;
			case 31:
			if(language==1)
				Think("Не больно.");
			else
				Think("It doesn't hurt.");
			break;
			case 32:
			if(language==1)
				Think("И сердце так загоняется под ребром точно не потому, что он рад услышать его голос.");
			else
				Think("And it's definitely not because he's happy to hear his voice.");
			break;
			case 33:
			if(language==1)
				Think("Андрюши не существует. ");
			else
				Think("Andryusha doesn't exist. ");
			break;
			case 34:
			if(language==1)
				Think("Это так, к слову. Можно разрешить себе по этому поводу не рефлексировать.");
			else
				Think("That's right, by the way. You can allow yourself not to reflect on this. ");
			break;
			case 35:
			yield return new WaitForEndOfFrame();
			NextCoroutine("F1");
			break;
		}
		st.CoroutineEnding();
	}
	private IEnumerator E1A2B1()
	{
		st.CoroutineBegining();
		switch(st.step)
		{
			case 0:
			TimeTravel("Квартира Андрея: Компьютерный стол\r\n2020", 0, 0);
			yield return new WaitForSecondsRealtime(12f/speed);
			break;
			case 1:
			SetAllButtons(true);
			Item(8);
			if(language==1)
				Think("27.11.2020");
			else
				Think("27.11.2020");
			break;
			case 2:
			if(language==1)
				Think("То, что Сукачев вернулся в свою комнату, он замечает не сразу —");
			else
				Think("The fact that Sukachev returned to his room, he notices not immediately —");
			break;
			case 3:
			if(language==1)
				Think("Вначале — рвётся в коридор, едва не снеся с петель дверь. Потом — чуть не сносит ещё одну, входную, громко ею хлопая, надеясь оставить всё позади… ");
			else
				Think("At the beginning, he rushes into the corridor, almost knocking the door off its hinges. Then - he almost blows another one, the entrance, loudly clapping it, hoping to leave everything behind ... ");
			break;
			case 4:
			if(language==1)
				Think("Всё —  и беснующуюся мать, и её напуганную девочку…");
			else
				Think("Everything — both the raging mother and her frightened girl…");
			break;
			case 5:
			if(language==1)
				Think("Но, ухватившись за ручку, останавливается. ");
			else
				Think("But, grabbing the handle, he stops. ");
			break;
			case 6:
			if(language==1)
				Think("Ручка — новенькая, свежая, совсем недавно установленная мастером. На ней его мертвенно бледные пальцы, компульсивно сжимающие имитацию под металл, выглядят, конечно, дико. ");
			else
				Think("The pen is brand new, fresh, just recently installed by the master. On it, his deathly pale fingers, compulsively squeezing the metal-like imitation, look, of course, wild. ");
			break;
			case 7:
			if(language==1)
				Think("Но");
			else
				Think("But");
			break;
			case 8:
			Show("a", "Центр");
			StartDissolve("a", 0);
			if(language==1)
				Say("a", "Но, но, но, но! ");
			else
				Say("a", "But, but, but, but! ");
			break;
			case 9:
			if(language==1)
				Say("a", "Руки, как у героинщика…", true);
			else
				Say("a", "Hands like a heroin addict…", true);
			break;
			case 10:
			PlaySound(10);
			if(language==1)
				Think("Андрей, дышащий, как загнанная до полусмерти лошадь, старается не съедать окончания и не подавиться насмерть вязкой, раздражающе холодными и грозящими забить лёгкие слезами. ");
			else
				Think("Andrey, breathing like a half-dead horse, tries not to eat the endings and not to choke to death with viscous, annoyingly cold tears that threaten to fill his lungs. ");
			break;
			case 11:
			PlaySound(8);
			if(language==1)
				Think("И продолжает, пытаясь вместе с тем отдышаться —");
			else
				Think("And continues, at the same time trying to catch his breath —");
			break;
			case 12:
			if(language==1)
				Say("a", " Но дело-то не в них…", true);
			else
				Say("a", " But it's not about them…", true);
			break;
			case 13:
			if(language==1)
				Say("a", "Нет.");
			else
				Say("a", "No.");
			break;
			case 14:
			if(language==1)
				Say("a", "Тишина!");
			else
				Say("a", "Silence!");
			break;
			case 15:
			if(language==1)
				Say("a", "Тут тихо! ");
			else
				Say("a", "It's quiet here! ");
			break;
			case 16:
			if(language==1)
				Say("a", "И ручка родная!");
			else
				Say("a", "And the pen is dear!");
			break;
			case 17:
			PlaySound(4);
			Dissolve("a", 1);
			if(language==1)
				Say("a", "*смеётся*");
			else
				Say("a", "*laughs*");
			break;
			case 18:
			if(language==1)
				Say("a", "Повезло тебе, Андрюша.");
			else
				Say("a", "Lucky you, Andryusha.");
			break;
			case 19:
			if(language==1)
				Say("a", "Ой как повезло.");
			else
				Say("a", "Oh, how lucky.");
			break;
			case 20:
			if(language==1)
				Think("Андрей, всё смеясь, возвращается как ни в чем не бывало назад, в свою комнату. ");
			else
				Think("Andrey, still laughing, returns as if nothing had happened back to his room. ");
			break;
			case 21:
			Dissolve("a", 0);
			if(language==1)
				Think("Побледневший, с дикими глазами, руками, всё ещё сжатыми в кулаки, и побелевшими костяшками — не разжать. ");
			else
				Think(" Pale, with wild eyes, hands still clenched into fists, and white knuckles - can not be unclenched. ");
			break;
			case 22:
			if(language==1)
				Think("Да оно и не надо, плееру всё равно — пластмасса на удивление крепкая. ");
			else
				Think("Yes, it is not necessary, the player does not care - the plastic is surprisingly strong. ");
			break;
			case 23:
			yield return new WaitForEndOfFrame();
			NextCoroutine("F1");
			break;
		}
		st.CoroutineEnding();
	}
	private IEnumerator F1()
	{
		st.CoroutineBegining();
		switch(st.step)
		{
			case 0:
			Dissolve("a", 0);
			if(language==1)
				Think("Плеер он суёт в карман, но выпустить из рук, перестать касаться пальцами, трогать жёлтый корпус, перебирать кнопки — не может");
			else
				Think("He puts the player in his pocket, but he can't let it go, stop touching with his fingers, touch the yellow body, touch the buttons - he can't ");
			break;
			case 1:
			if(language==1)
				Think("Но есть что-то ещё кроме чёртового плеера.");
			else
				Think("But there's something else besides the goddamn player.");
			break;
			case 2:
			if(language==1)
				Think("Андрей понимает, что не один, как обычно, а два телефона греют его карманы на джинсах. Телефоны, в отличие от своих версий, он не убивает, не сливает их в один корпус, не спаивает процессоры….");
			else
				Think("Andrey realizes that not one, as usual, but two phones are warming his jeans pockets. Phones, unlike its versions, it does not kill, does not merge them into one case, does not solder processors .... ");
			break;
			case 3:
			if(language==1)
				Say("a", "Тебя же тут не было, гад.");
			else
				Say("a", "You weren't here, bastard.");
			break;
			case 4:
			if(language==1)
				Think("Накрывает ладонью появившийся телефон и сразу же снимает блокировку, сходу открывая вконтач — прожив за полчаса 30 лет Андрюша только понял, что цитировать песенки не будет.");
			else
				Think(" Covers the appeared phone with his palm and immediately removes the lock, immediately opening vkontach - having lived 30 years in half an hour, Andryusha only realized that he would not quote songs. ");
			break;
			case 5:
			if(language==1)
				Say("a", "Может, фармить так десятые айфоны в прошлом и стать миллиардером? А может, лучше ставки делать?");
			else
				Say("a", "Maybe farm tenth iPhones like that in the past and become a billionaire? Or maybe it's better to place bets? ");
			break;
			case 6:
			if(language==1)
			ChoiceList(
			new string[]{"Разорить букмекерскую контору","Фармить айфоны","Продавать вещи из прошлого, как антиквариат",
			"Продать машину времени","Стать изобретателем, скопировав инфу из википедии","Загуглить другие варианты заработка"},
			new int[] { 3, 3, 3, 3, 3, 3 },
			new string[] { "F1", "F1", "F1", "F1A1", "F1", "F1" },
			new int[] { 7, 7, 7, 0, 7, 7 });
			else
			ChoiceList(
			new string[]{"Ruin a bookmaker's office","Farm iPhones","Sell things from the past like antiques",
			"Sell a time machine","Become an inventor by copying information from Wikipedia","Google other earning options"},
			new int[] { 3, 3, 3, 3, 3, 3 },
			new string[] { "F1", "F1", "F1", "F1A1", "F1", "F1" },
			new int[] { 7, 7, 7, 0, 7, 7 });
			break;
			case 7:
			if(language==1)
				Think("Андрей недвижимо стоит посреди своей комнаты 27 ноября 2020 года, уже приготовившись прыгнуть, когда ему в голову приходит ещё более безумная идея.");
			else
				Think("Andrew stands motionless in the middle of his room on November 27, 2020, ready to jump when an even crazier idea occurs to him.");
			break;
			case 8:
			if(language==1)
				Think("После всех адреналиновых трипов, после всего мрачного и жестокого, ему удовлетвориться тем, чего он всегда жаждал - эмоциями. ");
			else
				Think("After all the adrenaline trips, after all the dark and cruel things, he'll be satisfied with what he's always craved - emotions. ");
			break;
			case 9:
			if(language==1)
				Think("Из ещё одной пачки налички, или циферок в онлайн банке выжать Сукачев выжмет тот самый сносящий крышу драйв, вот только на сколько этого драйва хватит?");
			else
				Think("From one more wad of cash, or a number in an online bank, Sukachev will squeeze out that mind-blowing drive, but how much drive is enough?");
			break;
			case 10:
			if(language==1)
				Say("a", "Разве мы это уже не проходили?", true);
			else
				Say("a", "Didn't we go through this already?", true);
			break;
			case 11:
			if(language==1)
				Think("На полчаса, а дальше — тоска. ");
			else
				Think("For half an hour, and then - melancholy. ");
			break;
			case 12:
			if(language==1)
				Think("Так что если совершить что-то другое, совсем другое, например… ");
			else
				Think("So if you do something different, very different, like… ");
			break;
			case 13:
			if(language==1)
				Think("Ещё раз увидеть свою любимую бабушку? ");
			else
				Think("Seeing your beloved grandma again? ");
			break;
			case 14:
			if(language==1)
			ChoiceList(
			new string[] { "Я бы хотел с ней еще раз увидеться…", "Это неплохое прикрытие, чтобы в очередной раз сбежать от проблем" },
			new int[] { 3, 3 },
			new string[] { "F1", "F1" },
			new int[] { 15, 16 },
			new bool[] { true, true },
			new string[]{"Если <color=#A8FFFC>Искренность</color>>=1,\r\nто <color=#FF00D1>Безумие</color>+1, \r\n<color=#32E9AB>Эскапизм</color>+2, <color=#A8FFFC>Искренность</color>+2\r\nЕсли <color=#A8FFFC>Искренность</color><=0,\r\nто <color=#FF00D1>Безумие</color>+2",
			"<color=#32E9AB>Эскапизм</color>+1,\r\n<color=#FF00D1>Безумие</color>+1"});
			else
			ChoiceList(
			new string[] { "I'd like to see her again...", "That's a good cover to get out of trouble again" },
			new int[] { 3, 3 },
			new string[] { "F1", "F1" },
			new int[] { 15, 16 },
			new bool[] { true, true },
			new string[]{"If <color=#A8FFFC>Sincerity</color>>=1,\r\nthen <color=#FF00D1>Madness</color>+1, \r\n<color=#32E9AB> Escapism</color>+2, <color=#A8FFFC>Sincerity</color>+2\r\nIf <color=#A8FFFC>Sincerity</color><=0,\r\nthen <color=#FF00D1> Madness</color>+2",
			"<color=#32E9AB>Escapism</color>+1,\r\n<color=#FF00D1>Madness</color>+1"});
			break;
			case 15:
			if(gm.Stats["Искренность"]>=1)
				SetStats(new Dictionary<string, int> { { "Безумие", +1 }, { "Эскапизм", +2 }, { "Искренность", +2 } });
			else
				SetStats(new Dictionary<string, int> { { "Безумие", +2 } });
			if(language==1)
				Think("Андрей хмыкает себе под нос, растягивая губы в болезненной улыбке, смотря на открытую в браузере страницу Сани. Но монитор гаснет, и вот уже он замечает только своё отражение.");
			else
				Think("Andrey grunts under his breath, stretching his lips in a painful smile, looking at Sanya's page opened in the browser. But the monitor goes blank, and now he only notices his own reflection.");
			st.step=16;
			break;
			case 16:
			SetStats(new Dictionary<string, int> { { "Безумие", +1 }, { "Эскапизм", +1 } });
			if(language==1)
				Think("Андрей хмыкает себе под нос, растягивая губы в болезненной улыбке, смотря на открытую в браузере страницу Сани. Но монитор гаснет, и вот уже он замечает только своё отражение.");
			else
				Think("Andrey grunts under his breath, stretching his lips in a painful smile, looking at Sanya's page opened in the browser. But the monitor goes blank, and now he only notices his own reflection.");
			break;
			case 16+1:
			if(language==1)
				Think("Перед ним Андрей, в его одежде, прижимающий бережно пострадавшую руку.");
			else
				Think("Andrey is in front of him, in his clothes, holding his injured hand carefully.");
			break;
			case 17+1:
			Dissolve("a", 1);
			if(language==1)
				Say("a", "Андрюшечка, можешь ехать к бабушке, я разрешаю! ", true);
			else
				Say("a", " Andryushechka, you can go to your grandmother, I allow it! ", true);
			break;
			case 18+1:
			if(language==1)
				Think("Издевательски вскидывает руки, позабыв про боль. Неуклюже приближается к монитору и думает прижать Андрееву головушку к груди, погладить его по волосам и поцеловать в лоб, благословляя.");
			else
				Think("Jockingly throws up his hands, forgetting about the pain. He clumsily approaches the monitor and thinks of pressing Andreev's little head to his chest, stroking his hair and kissing his forehead, blessing him.");
			break;
			case 19+1:
			if(language==1)
				Think("Но вместо этого Андрей видит перед глазами свою уродливую, корчущуюся рожицу, похожую на иллюстрацию к гебефренической шизофрении.");
			else
				Think("But instead, Andrei sees his ugly, writhing face in front of his eyes, similar to an illustration of hebephrenic schizophrenia.");
			break;
			case 20+1:
			Dissolve("a", 0);
			if(language==1)
				Think("Он вздрагивает, открывая глаза, и бьёт себя по рукам за недавнюю идею обогатиться.");
			else
				Think("He flinches, opening his eyes, and slaps his hands for his recent idea to get rich.");
			break;
			case 21+1:
			if(language==1)
				Think("Потому что каждый раз от путешествия во времени тоненькая ниточка, соединяющая его с настоящим, с его реальной жизнью в 27.11.2020., становится ещё тоньше.");
			else
				Think("Because every time he travels through time, the thin thread connecting him to the present, to his real life on 11/27/2020., becomes even thinner.");
			break;
			case 22+1:
			if(language==1)
				Think("Внутри всё холодеет от мысли, что он может остаться в далёком прошлом+1: совершенно один, без средств к существованию, дитём в чужой эпохе. И познать там все прелести карательной психиатрии…");
			else
				Think("Everything gets cold inside from the thought that he can stay in the distant past +1: completely alone, without means of subsistence, a child in a foreign era. And to know there all the charms of punitive psychiatry ... ");
			break;
			case 23+1:
			if(language==1)
				Think("Да, и застрять в 25 ноября — туда же. ");
			else
				Think("Yes, and get stuck on November 25 - there too. ");
			break;
			case 24+1:
			if(language==1)
				Think("Нет, это даже хуже — Андрюша сиганет наконец-то с крыши, будет дрожать как осиновый лист, закружится от высоты голова…");
			else
				Think("No, it's even worse - Andryusha will finally jump from the roof, he will tremble like an aspen leaf, his head will spin from the height ... ");
			break;
			case 25+1:
			Move("a", "Центр", "Лево", 1f);
			Show("aa", "Центр", new Vector3(1f, 1f, 0));
			StartDissolve("aa", 0);
			Move("aa", "Центр", "Право", 1f);
			yield return new WaitForSecondsRealtime(1f/speed);
			if(language==1)
				Say("aa", "Хороший мальчик должен пойти исправить свои ошибки, ведь убийство себе подобных занимает особое место в человеческой душонке, даже такой.");
			else
				Say("aa", "A good boy should go and make amends, for killing one's own kind has a special place in the human soul, even this one.");
			break;
			case 27:
			if(language==1)
				Think("Ведь он, как бы ни пел, ни голосил о венцах эволюции, как бы ни отдавался дьяволу и ни целовал перстни демонице — не особенный, не пропащий, не зло во плоти, и не Мориарти ни разу — Андрей обычный человек.");
			else
				Think("After all, no matter how he sang, or wailed about the crowns of evolution, no matter how he gave himself to the devil and kissed the demoness's rings - not special, not lost, not evil in the flesh, and not Moriarty even once - Andrei is an ordinary person. ");
			break;
			case 28:
			if(language==1)
				Say("aa", "И это прискорбно.");
			else
				Say("aa", "And that's unfortunate.");
			break;
			case 26+3:
			if(language==1)
				Think("Поэтому идея вернуться в Краснодар 2003го года, увидеть бабушку и даже, может быть, остаться там навсегда, так захватывает его разум.");
			else
				Think("So the idea of \u200b\u200bgoing back to Krasnodar in 2003, seeing his grandma and maybe even staying there forever is so mind boggling.");
			break;
			case 27+3:
			if(language==1)
				Think("Как что-то самое искреннее, светлое и невинное среди всей этой мрачной каши.");
			else
				Think("Like something most sincere, bright and innocent among all this gloomy mess.");
			break;
			case 28+3:
			Move("a", "Лево", "Центр", 1f);
			EndDissolve("aa");
			Move("aa", "Право", "Центр", 1f);
			yield return new WaitForSecondsRealtime(1f/speed);
			if(language==1)
				Think("Может, позже, под коньяком, Андрей наберётся смелости убить одного немецкого художника, очистить коммунизм от Пол Пота, хотя и понимает, что будущее после этого станет ужасным по закону бабочки.");
			else
				Think("Maybe later, under cognac, Andrey will have the courage to kill one German artist, purge communism from Pol Pot, although he understands that the future after that will become terrible according to the law of the butterfly.");
			break;
			case 29+3:
			if(language==1)
				Think("Но он и не будет туда соваться.");
			else
				Think("But he won't go there.");
			break;
			case 30+3:
			if(language==1)
				Say("a", "Сначала —  к бабушке. Купить билет и снять денег впрок.", true);
			else
				Say("a", "First - to the grandmother. Buy a ticket and withdraw money for future use.", true);
			break;
			case 31+3:
			if(language==1)
				Think("Так он и поступает. ");
			else
				Think("So he does. ");
			break;
			case 32+3:
			Fade(3f);
			yield return new WaitForSecondsRealtime(2f/speed);
			EndDissolve("a");
			PlayMusic(4);
			SecondScene(0);
			yield return new WaitForSecondsRealtime(2f/speed);
			if(language==1)
				Think("Быстро сливает шесть тысяч на сайте дешёвых авиабилетов, попутно думая над извечным вопросом, летит он “на отдых” или “по работе”, раз уж поисковику позарез нужно провести опрос фокус группы.");
			else
				Think("Quickly dumps six thousand cheap air tickets on the site, simultaneously thinking about the age-old question, is he flying “on vacation” or “for work”, since the search engine desperately needs to conduct a survey of the focus group.");
			break;
			case 33+3:
			if(language==1)
				Think("Паспорт для подтверждения покупки");
			else
				Think("Passport for Proof of Purchase");
			break;
			case 34+3:
			if(language==1)
				Think("Крутится в кресле, введя все данные на телефоне, и заходит во все соц сети.");
			else
				Think("Spins around in his chair, entering all the data on the phone, and goes to all the social networks.");
			break;
			case 35+3:
			Messenger(2, 0);
			PlaySound(0);
			if(language==1)
				Say("a", "Я маму проведать, на пару дней.");
			else
				Say("a", "I'm going to visit my mom for a couple of days.");
			break;
			case 36+3:
			if(language==1)
				Think("Томбойка из всей рассылки отвечает первая, несмотря на раннее утро.");
			else
				Think("Tomboyka from the entire mailing list is the first to answer, despite the early morning.");
			break;
			case 37+3:
			Messenger(2, 1);
			PlaySound(0);
			if(language==1)
				Say("sh", "Мне тебе не писать?");
			else
				Say("sh", "Shouldn't I text you?");
			break;
			case 38+3:
			Messenger(2, 2);
			PlaySound(0);
			if(language==1)
				Say("a", "Почему же? Как раз самое время пиздеть. Работы нет, на вписку не пустят, только ты и остаёшься");
			else
				Say("a", "Why? It's just about time to fuck. There is no work, they will not let you in, only you remain ");
			break;
			case 39+3:
			Messenger(2, 3);
			PlaySound(0);
			if(language==1)
				Say("sh", "Когда на тебя забили все твои друзья, набираешь мне *-*");
			else
				Say("sh", "When all your friends beat you up, dial me *-*");
			break;
			case 40+3:
			Messenger(2, 4);
			PlaySound(0);
			if(language==1)
				Say("sh", "Бля прости, только не блокируй меня, я рада, правда");
			else
				Say("sh", "Shit, sorry, but don't block me, I'm glad, really");
			break;
			case 41+3:
			Messenger(2, 5);
			PlaySound(0);
			if(language==1)
				Say("sh", "Ты поверишь мне, что это не сарказм?");
			else
				Say("sh", "Will you believe me this isn't sarcasm?");
			break;
			case 42+3:
			if(language==1)
				Think("И она первая же бросается редактировать свое сообщение во что-то длинное и невразумительное.");
			else
				Think("And she's the first to rush to edit her post into something long and unintelligible.");
			break;
			case 43+3:
			PlaySound(4);
			if(language==1)
				Think("Андрей всё читает и хмыкает, рассмеявшись коротко — над предсказуемостью девочки, которая раз в переписку стабильно показывает свои молочные наточенные зубки, кокетничает, а потом сразу же снова кланяется ему в ноги.");
			else
				Think("Andrey reads everything and chuckles, laughing shortly - at the predictability of a girl who once in a correspondence consistently shows her milk sharpened teeth, flirts, and then immediately bows at his feet again. ");
			break;
			case 44+3:
			Messenger(2, 6);
			PlaySound(0);
			if(language==1)
				Say("a", "Знаешь, именно из-за этого я тебя и не блокирую ;)");
			else
				Say("a", "You know, that's why I don't block you ;)");
			break;
			case 45+3:
			if(language==1)
				Think("Закрывает, не читая, что она там отвечает, и пишет то же самое Феде, лучшему другу, с небольшими изменениями.");
			else
				Think("Closes without reading what she says there and writes the same to Fedya, her best friend, with minor changes.");
			break;
			case 46+3:
			Messenger(3, 0);
			PlaySound(0);
			if(language==1)
				Say("a", "Я маму проведать, на пару дней.");
			else
				Say("a", "I'm going to visit my mom for a couple of days.");
			break;
			case 47+3:
			Messenger(3, 1);
			PlaySound(0);
			if(language==1)
				Say("a", "Вернусь другим человеком!");
			else
				Say("a", "I'll be back a different person!");
			break;
			case 48+3:
			if(language==1)
				Think("И получает новую порцию");
			else
				Think("And gets a new portion");
			break;
			case 49+3:
			Messenger(3, 2);
			PlaySound(0);
			if(language==1)
				Say("f", "Не смешно, Андрей.");
			else
				Say("f", "Not funny, Andrew.");
			break;
			case 53:
			Messenger(3, 3);
			PlaySound(0);
			if(language==1)
				Say("f", "Если ты ещё не совсем конченный  — не уходи в запой из-за такой хуйни");
			else
				Say("f", "If you're not completely finished yet - don't go on a drinking binge because of such garbage ");
			break;
			case 54:
			Messenger(3, 4);
			PlaySound(0);
			if(language==1)
				Say("f", "Я буду через час, не смей делать глупости, иначе это конец нашей с тобой дружбы");
			else
				Say("f", "I'll be back in an hour, don't you dare do anything stupid, otherwise this is the end of our friendship with you ");
			break;
			case 55:
			Messenger(3, 5);
			PlaySound(0);
			if(language==1)
				Say("f", "Прости, но смотреть, как ты торчишь, я больше не хочу. Мне хватило. Если ты сам не захочешь выкарабкаться — никто тебе не поможет");
			else
				Say("f", "Sorry, but I don't want to watch you hang around anymore. I've had enough. If you yourself do not want to get out - no one will help you ");
			break;
			case 56:
			Messenger(3, 6);
			PlaySound(0);
			if(language==1)
				Say("f", "Да, все курят, но соли… Андрей, это смерть");
			else
				Say("f", "Yes, everyone smokes, but salt… Andrey, this is death");
			break;
			case 57:
			Messenger(3, 7);
			PlaySound(0);
			if(language==1)
				Say("a", "Оставь истерику, я правда к маме еду, вот билет уже купил");
			else
				Say("a", "Stop the tantrum, I'm really going to my mother, I've already bought a ticket ");
			break;
			case 58:
			Messenger(3, 8);
			PlaySound(0);
			if(language==1)
				Say("f", "Что-то серьёзное?");
			else
				Say("f", "Something serious?");
			break;
			case 59:
			if(language==1)
				Think("Пишет Федя, хотя прекрасно знает, что сознается Андрей только тогда, когда всё уже случится и сделать уже ничего будет нельзя.");
			else
				Think("Written by Fedya, although he knows perfectly well that Andrei confesses only when everything has already happened and nothing can be done.");
			break;
			case 60:
			Messenger(3, 9);
			PlaySound(0);
			if(language==1)
				Say("a", "Не, соскучился");
			else
				Say("a", "Not, I miss you ");
			break;
			case 61:
			Messenger(3, 10);
			PlaySound(0);
			if(language==1)
				Say("a", "Ну ладно, я в аэропорт");
			else
				Say("a", "Okay, I'm going to the airport");
			break;
			case 62:
			Messenger(3, 11);
			PlaySound(0);
			if(language==1)
				Say("f", "Рано ещё");
			else
				Say("f", "Early yet");
			break;
			case 63:
			Messenger(3, 12);
			PlaySound(0);
			if(language==1)
				Say("a", "Похуй");
			else
				Say("a", "Fuck");
			break;
			case 64:
			if(language==1)
				Think("С остальными Андрей даже не включается, не выходит из транса, крутясь в кресле так быстро, что начинает тошнить. ");
			else
				Think("With the rest Andrey doesn't even turn on, doesn't come out of his trance, spinning in his chair so fast that he starts to feel sick. ");
			break;
			case 65:
			if(language==1)
				Think("Так, механически печатает буковками, не читая. И смайлы ставит какие-то, кроме скобочек.");
			else
				Think("So, mechanically typing letters without reading. And puts some emoticons, except brackets. ");
			break;
			case 66:
			if(language==1)
				Think("Ему предлагают заменить слово на смайл, а он? Меняет.");
			else
				Think("He is offered to replace the word with a smiley, but he? Changes.");
			break;
			case 67:
			if(language==1)
				Think("И бежит собирать сумку, деньги решив снять уже там.");
			else
				Think("And runs to collect the bag, deciding to withdraw the money already there.");
			break;
			case 68:
			yield return new WaitForEndOfFrame();
			if(gm.Stats["Root"]==1)
				NextCoroutine("F1A2");
			else if(gm.Stats["Root"]==2)
				NextCoroutine("F1A3");
			else
			{
				if(gm.Stats["Безумие"]>=3)
					NextCoroutine("F1A3B1");
				else
					NextCoroutine("G1", 4);
			}
			break;
		}
		st.CoroutineEnding();
	}
	private IEnumerator F1A1()
	{
		st.CoroutineBegining();
		switch(st.step)
		{
			case 0:
			StopMusic();
			Fade(30f, language==1 ? "Игра окончена?\r\nНа этом приключения заканчиваются." : "Game over?\r\nThis is where the adventure ends.");
			yield return new WaitForSecondsRealtime(6f);
			SceneManager.LoadScene(0);
			break;
		}
		st.CoroutineEnding();
	}
	private IEnumerator F1A2()
	{
		st.CoroutineBegining();
		switch(st.step)
		{
			case 0:
			SandInfoMessage(language==1 ? "Чувства к <color=#F0000E>Сане</color>" : "Feelings for <color=#F0000E>Sanya</color>");
			Messenger(5, 0);
			PlaySound(0);
			if(language==1)
				Say("s", "Здравствуйте! Чтобы посмотреть моё местоположение, выберите в меню \"отслеживать GPS\" ");
			else
				Say("s", "Hello! To see my location, select \"track GPS\" from the menu");
			break;
			case 1:
			Messenger(5, 1);
			PlaySound(0);
			if(language==1)
				Say("s", "Ты, я, Краснодар, 100/0");
			else
				Say("s", "You, me, Krasnodar, 100/0");
			break;
			case 2:
			Messenger(5, 2);
			PlaySound(0);
			if(language==1)
				Say("s", "накраснодар.jpg");
			else
				Say("s", "nakrasnodar.jpg");
			Show("s", "Центр", new Vector3(0.5f, 0.5f, 0), new Vector3(0, 2.06f, 0));
			StartDissolve("s", 1);
			yield return new WaitForSecondsRealtime(1.5f);
			EndDissolve("s");
			break;
			case 3:
			Messenger(5, 3);
			PlaySound(0);
			if(language==1)
				Say("s", "А твоя «Франческа»?");
			else
				Say("s", "And your Francesca?");
			break;
			case 4:
			Messenger(5, 4);
			PlaySound(0);
			if(language==1)
				Say("s", "Красива, Сукачев, красива…");
			else
				Say("s", "Beautiful, Sukachev, beautiful…");
			break;
			case 5:
			yield return new WaitForEndOfFrame();
			if(gm.Stats["Безумие"]>3)
				NextCoroutine("F1A3B1");
			else
				NextCoroutine("G1", 4);
			break;
		}
		st.CoroutineEnding();
	}
	private IEnumerator F1A3()
	{
		st.CoroutineBegining();
		switch(st.step)
		{
			case 0:
			SandInfoMessage(language==1 ? "Чувства к <color=#FD9A00>Жене</color>" : "Feelings for <color=#FD9A00>Shenya</color>");
			PlaySound(0);
			if(language==1)
				Think("Точнее, бежал бы, но уведомления ему этого сделать не дают — у всех же отключил, кроме Феди и...");
			else
				Think("More precisely, he would have run, but he is not given notifications to do this - he turned it off for everyone, except for Fedi and ... ");
			break;
			case 1:
			if(language==1)
				Think("Жени. ");
			else
				Think("Zhenya. ");
			break;
			case 2:
			if(language==1)
				Think("Конечно же Жени. ");
			else
				Think("Of course Zhenya. ");
			break;
			case 3:
			if(language==1)
				Think("В очередной раз подрубил их, как только увидел, что пишет она уже больше минуты — нужно же убедиться, что написанное, как всегда, — хуйня, на которую и ответить нечего. ");
			else
				Think(" Once again I cut them off as soon as I saw that she had been writing for more than a minute - you need to make sure that what you wrote, as always, is garbage, to which there is nothing to answer. ");
			break;
			case 4:
			if(language==1)
				Say("a", "За год научилась бы уже сначала в заметках писать, чтобы не было потом так мучительно стыдно, как в наш первый кризис.");
			else
				Say("a", "In a year, I would have learned to write in notes first, so that later I would not be so painfully ashamed, as in our first crisis. ");
			break;
			case 5:
			if(language==1)
				Say("a", "Три месяца прообщались.");
			else
				Say("a", "Three months of talking.");
			break;
			case 6:
			if(language==1)
				Think("Когда же заходит в диалог, там нет ничего.");
			else
				Think("When it enters the dialog, there is nothing there.");
			break;
			case 7:
			Show("aa", "Право");
			StartDissolve("aa", 0);
			if(language==1)
				Say("aa", "Какая умная девочка, сама вынесла мусор! Все бы так, да, Андрюшка? И не было бы у нас с тобой проблем.");
			else
				Say("aa", "What a smart girl, she took out the trash herself! Everything would be so, right, Andryushka? And we wouldn't have any problems with you.");
			break;
			case 8:
			PlaySound(4, 0.8f);
			if(language==1)
				Say("aa", "*ухмыляется*", true);
			else
				Say("aa", "*grins*", true);
			break;
			case 9:
			if(language==1)
				Say("a", "Удалила и удалила. ");
			else
				Say("a", "Deleted and deleted. ");
			break;
			case 10:
			PlaySound(4);
			if(language==1)
				Think("Андрей тоже ухмыляется.");
			else
				Think("Andrey is also grinning.");
			break;
			case 11:
			if(language==1)
				Think("И быстро набирает ответ на несуществующее сообщение. ");
			else
				Think("And rapidly typing a response to a non-existent message. ");
			break;
			case 12:
			EndDissolve("aa");
			Messenger(4, 0);
			PlaySound(0);
			if(language==1)
				Say("АНДРЮША СУКАЧЕВ", "Мамка-то у меня из Краснодара, Женек");
			else
				Say("ANDRYUSHA SUKACHEV", "My mother is from Krasnodar, Zhenek");
			break;
			case 13:
			Messenger(4, 1);
			PlaySound(0);
			if(language==1)
				Say("АНДРЮША СУКАЧЕВ", "Прикинь какое совпадение");
			else
				Say("ANDRYUSHA SUKACHEV", "Estimate what a coincidence");
			break;
			case 14:
			Messenger(4, 2);
			PlaySound(0);
			if(language==1)
				Think("Всё, что она ему отвечает, — знак вопроса. ");
			else
				Think("Everything she answers him is a question mark. ");
			break;
			case 15:
			if(language==1)
				Say("a", "Это даже не смешно. ");
			else
				Say("a", "This isn't even funny. ");
			break;
			case 16:
			if(language==1)
				Say("a", "Уж лучше бы душная простыня…");
			else
				Say("a", "A stuffy sheet would be better…");
			break;
			case 17:
			if(language==1)
				Say("a", "Чем так.");
			else
				Say("a", "What so.");
			break;
			case 18:
			if(language==1)
				Say("a", "Неинтересно.");
			else
				Say("a", "Not interested.");
			break;
			case 19:
			if(language==1)
				Say("a", "Женек, где же твой запал? ");
			else
				Say("a", "Zhenek, where is your fuse? ");
			break;
			case 20:
			if(language==1)
				Say("a", "Неужто за полчаса обломали все зубки? ");
			else
				Say("a", "Did you break all your teeth in half an hour? ");
			break;
			case 21:
			if(language==1)
				Think("Спустя пару секунд бросает взгляд на экран, снова. И очень удивляется увиденному…");
			else
				Think("After a couple of seconds, he glances at the screen again. And he is very surprised at what he sees…");
			break;
			case 22:
			Messenger(4, 3);
			if(language==1)
				Think("Как все эти Андрюшины фразы оказались в прочитанных Женей сообщениях — он не знает. ");
			else
				Think(" How all these Andryusha's phrases ended up in the messages read by Zhenya - he does not know. ");
			break;
			case 23:
			yield return new WaitForEndOfFrame();
			NextCoroutine("F1A3B2");
			break;
		}
		st.CoroutineEnding();
	}
	private IEnumerator F1A4()
	{
		st.CoroutineBegining();
		switch(st.step)
		{
			case 0:
			break;
			case 1:
			break;
			case 2:
			break;
			case 3:
			break;
			case 4:
			break;
			case 5:
			break;
			case 6:
			break;
			case 7:
			break;
			case 8:
			break;
			case 9:
			break;
			case 10:
			break;
			case 11:
			break;
			case 12:
			break;
			case 13:
			break;
			case 14:
			break;
			case 15:
			break;
			case 16:
			break;
			case 17:
			break;
			case 18:
			break;
			case 19:
			break;
		}
		yield return new WaitForEndOfFrame();
		st.CoroutineEnding();
	}
	private IEnumerator F1A3B1()
	{
		st.CoroutineBegining();
		switch(st.step)
		{
			case 0:
			StopMusic();
			SandInfoMessage(language==1 ? "Высокое <color=#FF00D1>Безумие</color>" : "High <color=#FF00D1>Madness</color>");
			st.SetMaterial(0, new Dictionary<string, float> { { "_WaveSpeed", 3f }, { "_WaveAmplitude", 0.02f } });
			Show("aa", "Право", new Vector3(1.5f, 1.5f, 0));
			StartDissolve("aa", 1);
			if(language==1)
				Think("Руки дрожат, а на плече — чья-то ледяная рука сжимает край футболки, оттягивает так, чтобы Андрею было легче дышать, и опаляет дыханием шею.");
			else
				Think("Hands tremble, and on his shoulder - someone's icy hand squeezes the edge of the T-shirt, pulls it so that Andrei can breathe easier, and scorches his neck with his breath.");
			break;
			case 1:
			st.SetMaterial(0, new Dictionary<string, float> { { "_WaveSpeed", 3.5f }, { "_WaveAmplitude", 0.03f } });
			PlaySound(14);
			Zoom("aa", new Vector3(1.5f, 1.5f, 0), new Vector3(3f, 3f, 0), 1f);
			Move("aa", "Право", "Право", 1f, new Vector2(0f, 0f), new Vector2(0f, -2f));
			if(language==1)
				Say("aa", "Не благодари.");
			else
				Say("aa", "Don't thank.");
			break;
			case 2:
			st.SetMaterial(0, new Dictionary<string, float> { { "_WaveSpeed", 4f }, { "_WaveAmplitude", 0.05f } });
			PlaySound(1);
			PlayMusic(9);
			Shake();
			Zoom("aa", new Vector3(3f, 3f, 0), new Vector3(1f, 1f, 0), 1f);
			Move("aa", "Право", "Право", 1f, new Vector2(0f, -2f), new Vector2(0f, 0f));
			if(language==1)
				Say("a", "ЧТО ЗА НАХУЙ?!");
			else
				Say("a", "WHAT THE FUCK?!");
			break;
			case 3:
			EndDissolve("aa");
			if(language==1)
				Think("Андрей скидывает чужую руку. Чужую блядь руку, осязаемую! ");
			else
				Think("Andrey folds his hand. Someone else's fucking hand, tangible! ");
			break;
			case 4:
			if(language==1)
				Think("Слышит, как несуществующая, нематериальная субличность шаркает по ковру кроссовками. ");
			else
				Think("Hears a non-existent, intangible subpersonality shuffling sneakers across the carpet. ");
			break;
			case 5:
			PlaySound(20, 0.8f);
			Show("aa", "Центр", new Vector3(1f, 1f, 0));
			StartDissolve("aa", 2);
			yield return new WaitForSecondsRealtime(0.8f);
			Zoom("aa", new Vector3(1f, 1f, 0), new Vector3(3f, 3f, 0), 0.2f);
			Thrill("aa");
			yield return new WaitForSecondsRealtime(0.3f);
			//Dissolve("aa",1);
			Zoom("aa", new Vector3(3f, 3f, 0), new Vector3(2f, 2f, 0), 0.2f);
			if(language==1)
				Say("aa", "Ахахахахаха");
			else
				Say("aa", "Ahahahahaha");
			break;
			case 6:
			if(language==1)
				Say("aa", " Говорю же: \"не благодари\", Андрюша.");
			else
				Say("aa", " I say: \"don't thank\", Andryusha.");
			break;
			case 7:
			Thrill("aa");
			Dissolve("aa", 3);
			if(language==1)
				Say("aa", "ТЫ ЧТО, ОГЛОХ?! ");
			else
				Say("aa", "Are you deaf?! ");
			break;
			case 8:
			LongShaker(4f, 3f);
			PlaySound(15);
			if(language==1)
				Think("Тульпа кричит так, что, Андрей уверен, побила бы ему все чайные советские сервизы, не избавься от них Сукачев… ");
			else
				Think("Tulpa screams so that, Andrey is sure, she would beat all the Soviet tea sets for him, if Sukachev did not get rid of them ... ");
			break;
			case 9:
			EndDissolve("aa");
			if(language==1)
				Think("…И, подмигнув, исчезает, оставив после себя лишь эхо.");
			else
				Think("… And with a wink, disappears, leaving behind only an echo.");
			break;
			case 10:
			yield return new WaitForEndOfFrame();
			NextCoroutine("G1", 4);
			break;
		}
		st.CoroutineEnding();
	}
	private IEnumerator F1A3B2()
	{
		st.CoroutineBegining();
		switch(st.step)
		{
			case 0:
			Fade(2f);
			yield return new WaitForSecondsRealtime(2f);
			st.SetMaterial(0, new Dictionary<string, float> { { "_WaveSpeed", 2.5f }, { "_WaveAmplitude", 0.003f } });
			PlayMusic(4);
			EndDissolve("aa");
			Scene(0);
			if(language==1)
				Think("Он этого не делал. Не писал это чёртово шизофреническое нытье только что удалившей своё Жене. ");
			else
				Think("He didn't do it. I did not write this damn schizophrenic whining to Zhenya who had just deleted hers. ");
			break;
			case 1:
			if(language==1)
				Say("a", "Не делал.");
			else
				Say("a", "Didn't.");
			break;
			case 2:
			if(language==1)
				Say("a", "Я блядь точно помню. ");
			else
				Say("a", "I fucking remember exactly. ");
			break;
			case 3:
			if(language==1)
				Say("a", "Этого всего не было");
			else
				Say("a", "It didn't happen at all");
			break;
			case 4:
			if(language==1)
				Say("a", "Не было.");
			else
				Say("a", "Wasn't.");
			break;
			case 5:
			if(language==1)
				Say("a", "Блядь не было.");
			else
				Say("a", "Damn it didn't happen.");
			break;
			case 6:
			if(language==1)
				Say("a", "Не было, сука!!!! ");
			else
				Say("a", "No, bitch!!!! ");
			break;
			case 7:
			PlaySound(0);
			if(language==1)
				Think("Дзынь-дзынь.");
			else
				Think("Tink-ding.");
			break;
			case 8:
			if(language==1)
				Think("Пришло сообщение от Жени.");
			else
				Think("Message from Zhenya.");
			break;
			case 9:
			if(language==1)
				Think("Но теперь его не читает уже Андрей.");
			else
				Think("But now Andrey doesn't read it anymore.");
			break;
			case 10:
			Show("aa", "Лево", new Vector3(-1f, 1f, 0));
			StartDissolve("aa", 0);
			if(language==1)
				Say("aa", "А ты же вроде бы хотел скинуть ей фотку подарка.");
			else
				Say("aa", "And you seem to want to send her a picture of a gift.");
			break;
			case 11:
			if(language==1)
				Say("aa", "Или передумал дарить ей машину времени?");
			else
				Say("aa", "Or change your mind about giving her a time machine?");
			break;
			case 12:
			if(language==1)
				Say("aa", " А, Андрюш? ", true);
			else
				Say("aa", " And Andrew? ", true);
			break;
			case 13:
			PlaySound(14);
			EndDissolve("aa");
			if(language==1)
				Say("aa", "*смеётся*");
			else
				Say("aa", "*laughs*");
			break;
			case 14:
			yield return new WaitForEndOfFrame();
			if(gm.Stats["Безумие"]>=3)
				NextCoroutine("F1A3B1");
			else
				NextCoroutine("G1", 4);
			break;
		}
		st.CoroutineEnding();
	}
}
