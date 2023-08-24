using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Story04 : Story
{
	private IEnumerator G1()
	{
		st.CoroutineBegining();
		switch(st.step)
		{
			case 0:
				Fade(4f,language==1 ? "Аэропорт\r\n27.11.2020 12:37" : "Airport\r\n27.11.2020 12:37");
				yield return new WaitForSecondsRealtime(2f);
				st.SetMaterial(0,new Dictionary<string,float> { { "_WaveSpeed",2.5f },{ "_WaveAmplitude",0.003f } });
				EndDissolve("aa");
				PlayMusic(3);
				Scene(5);
				yield return new WaitForSecondsRealtime(2f);
				if(language==1)
					Think("В первый раз в аэропорту Андрей оказался, когда прилетел сюда из Волгограда — его первое настоящее путешествие.");
				else
					Think("The first time Andrey was at the airport was when he flew here from Volgograd — his first real trip.");
				break;
			case 1:
				if(language==1)
					Think("Оно уже отошло на второй план, уступив место турам по городам, десяткам других аэропортов… ");
				else
					Think("It has already faded into the background, giving way to city tours, dozens of other airports… ");
				break;
			case 2:
				if(language==1)
					Think("Где они сидят с Федей за большим столом в компании девчонок, постоянно меняющихся, едят бутерброды по шестьсот рублей и пьют чай немногим дешевле. Играют в дурака, подмешивая в чай коньяк из своих чемоданов, пока не объявили посадку на их рейс…");
				else
					Think("Where they sit with Fedya at a large table in the company of girls who are constantly changing, eat sandwiches for six hundred rubles and drink tea a little cheaper. Playing the fool by mixing cognac from their suitcases into their tea until they are called to board their flight…");
				break;
			case 3:
				if(language==1)
					Think("Сейчас до посадки три часа.");
				else
					Think("It's three hours until landing.");
				break;
			case 4:
				if(language==1)
					Think("Есть одно незаконченное дело.");
				else
					Think("There is one unfinished business.");
				break;
			case 5:
				if(language==1)
					Think("Андрей подходит к банкомату, опьяненный властью, недоступной простым смертным, но тут же себя осаждает, мысленно бросает с моста вниз, расшибается насмерть и тонет в депрессии…");
				else
					Think("Andrey approaches the ATM, intoxicated by the power inaccessible to mere mortals, but immediately besieges himself, mentally throws him down from the bridge, kicks himself to death and drowns in depression…");
				break;
			case 6:
				Show("aa","Право");
				StartDissolve("aa",0);
				if(language==1)
					Say("aa","Юноша с демонами, рвущимися наружу, и переварившими внутренности твои — играй в театре кукол сам собой, давай представления!");
				else
					Say("aa","Young man with demons rushing out and digesting your insides - play in the puppet theater by yourself, give performances!");
				break;
			case 7:
				PlaySound(16);
				if(language==1)
					Think("<u><color=green>pin: 8991</color></u>",true);
				else
					Think("\u003cu\u003e\u003ccolor\u003dgreen\u003epin: 8991\u003c/color\u003e\u003c/u\u003e",true);
				break;
			case 8:
				EndDissolve("aa");
				PlaySound(16,1.1f);
				if(language==1)
					Think("<u><color=green>Ввод.</color></u>",true);
				else
					Think("\u003cu\u003e\u003ccolor\u003dgreen\u003eEnter.\u003c/color\u003e\u003c/u\u003e",true);
				break;
			case 9:
				PlaySound(16);
				if(language==1)
					Think("<u><color=green>Баланс.</color></u>",true);
				else
					Think("\u003cu\u003e\u003ccolor\u003dgreen\u003eBalance.\u003c/color\u003e\u003c/u\u003e",true);
				break;
			case 10:
				PlaySound(16,0.9f);
				if(language==1)
					Think("<u><color=green>На чеке.</color></u>",true);
				else
					Think("\u003cu\u003e\u003ccolor\u003dgreen\u003eOn receipt.\u003c/color\u003e\u003c/u\u003e",true);
				break;
			case 11:
				PlaySound(16,0.8f);
				if(language==1)
					Think("<u><color=green>pin: 2379</color></u>",true);
				else
					Think("\u003cu\u003e\u003ccolor\u003dgreen\u003epin: 2379\u003c/color\u003e\u003c/u\u003e",true);
				break;
			case 12:
				PlaySound(16,1.05f);
				if(language==1)
					Think("<u><color=green>Ввод.</color></u>",true);
				else
					Think("\u003cu\u003e\u003ccolor\u003dgreen\u003eEnter.\u003c/color\u003e\u003c/u\u003e",true);
				break;
			case 13:
				PlaySound(16);
				if(language==1)
					Think("<u><color=green>Баланс.</color></u>",true);
				else
					Think("\u003cu\u003e\u003ccolor\u003dgreen\u003eBalance.\u003c/color\u003e\u003c/u\u003e",true);
				break;
			case 14:
				PlaySound(16,1.15f);
				if(language==1)
					Think("<u><color=green>На чеке.</color></u>",true);
				else
					Think("\u003cu\u003e\u003ccolor\u003dgreen\u003eOn receipt.\u003c/color\u003e\u003c/u\u003e",true);
				break;
			case 15:
				PlaySound(17);
				if(language==1)
					Think("С лёгкой душой снимает всё до остатка с первой карты.");
				else
					Think("With a light heart, he removes everything from the first card to the rest.");
				break;
			case 16:
				if(language==1)
					Think("Быстро прячет наличку в карман, пока делает вид, что возится в рюкзаке. Достаёт кожаный кошелек и, тщательно прочитав шестьсот рублей сотками, аккуратно укладывает их в кошелек, сжимая пятитысячные купюры в рюкзаке так, чтобы никто не увидел всей суммы.");
				else
					Think("Quickly slips the cash into his pocket while pretending to fiddle around in his backpack. He takes out a leather purse and, having carefully read six hundred rubles in hundreds, carefully puts them in the purse, squeezing five thousandth bills in his backpack so that no one sees the entire amount.");
				break;
			case 17:
				if(language==1)
					Say("a","Теперь нужно найти себе место, сгрузить рюкзак в ноги, чтобы…");
				else
					Say("a","Now you need to find a place for yourself, unload the backpack at your feet to…");
				break;
			case 18:
				Show("aa","Лево",new Vector3(-1f,1f,0));
				StartDissolve("aa",0);
				if(language==1)
					Say("aa","Открыть коньяк и глушить его в одну харю?");
				else
					Say("aa","Open cognac and sip it in one mug?");
				break;
			case 19:
				if(language==1)
					Think("Место находится: рядом с мужчиной, сидящим в своём телефоне, около которого стоит ярко-фиолетовый чемодан с Твайлайт Спаркл.");
				else
					Think("Location is: next to a man on his phone with a bright purple suitcase containing Twilight Sparkle.");
				break;
			case 20:
				EndDissolve("aa");
				PlaySound(19);
				if(language==1)
					Think("Мужчина ничего не говорит, не отворачивается и не пытается отсесть от него, когда Андрей достаёт виски и делает сразу несколько больших глотков. ");
				else
					Think("The man doesn't say anything, doesn't turn away or try to sit away from him when Andrey pulls out whiskey and takes several long sips at once. ");
				break;
			case 21:
				st.SetMaterial(0,new Dictionary<string,float> { { "_WaveSpeed",3f },{ "_WaveAmplitude",0.01f } });
				if(language==1)
					Think("Горло щиплет, разливается по всему рту, этанолом обжигает десна, жмурит мокрые ресницы, слипшиеся от слёз, и тут же стирает, и жадно вздыхает, сглатывает, и снова прикладывается к горлышку — у него всегда есть повод.");
				else
					Think("Throat stings, spills all over mouth, ethanol burns gums, squints wet eyelashes stuck together from tears, and immediately erases, and sighs greedily, swallows, and again applied to the neck - he always has a reason.");
				break;
			case 22:
				if(language==1)
					Think("Смотрит вникуда и думает, правильно ли он поступает, летя в Краснодар. К своей наивной мечте увидеть бабушку и остаться жить в нулевых.");
				else
					Think("Looks around and wonders if he's doing the right thing by flying to Krasnodar. To my naive dream to see my grandmother and stay in the noughties.");
				break;
			case 23:
				Show("aa","Центр");
				StartDissolve("aa",0);
				if(language==1)
					Say("aa","Ты даже не пробовал оставаться во времени путешествия надолго и ещё не был в будущем, а уже внутренне сложил крылышки, оставшись жить в своей наивной мечте — с бабушкой в 2003…. ");
				else
					Say("aa","You haven't even tried to stay in the travel time for a long time and haven't been in the future yet, but you already folded your wings internally, left to live in your naive dream - with your grandmother in 2003…. ");
				break;
			case 24:
				if(language==1)
					Say("aa","И кстати: деньги-то в 2003 были образца 2001, а у тебя 2020.",true);
				else
					Say("aa","And by the way: the money in 2003 was 2001, and you have 2020.",true);
				break;
			case 25:
				StopMusic();
				PlaySound(18);
				if(language==1)
					Think("Андрей широко распахивает глаза. Сердце стучит в ушах, потеют ладошки, страх долбит по нервам…");
				else
					Think("Andrey opens his eyes wide. The heart is pounding in the ears, the palms are sweating, the fear is pounding on the nerves ... ");
				break;
			case 26:
				PlaySound(1);
				Shake();
				if(language==1)
					Say("a","Какой же я тупой блядь дегенерат…");
				else
					Say("a","What a stupid fucking degenerate I am…");
				break;
			case 27:
				EndDissolve("aa");
				PlayMusic(9);
				st.SetMaterial(0,new Dictionary<string,float> { { "_WaveSpeed",30f },{ "_WaveAmplitude",0.015f } });
				if(language==1)
					Think("Он несётся со своего места куда-нибудь подальше, где нет людей, по пути сшибая какую-ту женщину плечом. Та чудом удерживается на ногах.");
				else
					Think("He rushes from his seat somewhere far away, where there are no people, knocking over some woman with his shoulder along the way. She miraculously stays on her feet. ");
				break;
			case 28:
				if(language==1)
					Say("a","Извините!");
				else
					Say("a","Sorry!");
				break;
			case 29:
				if(language==1)
					Think("Она извинений не слышит, да и ему похуй.");
				else
					Think("She doesn't hear the apology, and he doesn't give a fuck.");
				break;
			case 30:
				if(language==1)
					Think("И наконец видит: тихий угол, где даже уборщик, наверное, появляется лишь раз в неделю.");
				else
					Think("And finally sees: a quiet corner where even the janitor probably only shows up once a week.");
				break;
			case 31:
				Fade(2f);
				yield return new WaitForSecondsRealtime(2f);
				st.SetMaterial(0,new Dictionary<string,float> { { "_WaveSpeed",2.5f },{ "_WaveAmplitude",0.003f } });
				Scene(6);
				PlayMusic(5);
				yield return new WaitForSecondsRealtime(1f);
				if(language==1)
					Think("Он становится туда, вжавшись в стену, хватается за голову и думает, думает, думает, разговаривая шепотом сам с собой…");
				else
					Think("He stands there, pressing himself against the wall, clutching his head and thinking, thinking, thinking, talking in whispers to himself…");
				break;
			case 32:
				if(language==1)
					Say("a","Пару минут с бабушкой того стоят, даже если я застряну там и окажусь в тюрьме за фальшивые деньги, наверное, только, только…");
				else
					Say("a","A couple of minutes with grandma is worth it, even if I get stuck there and end up in jail for counterfeit money, probably only, only…");
				break;
			case 33:
				if(language==1)
					Say("a","Эта хуйня ведь ещё и сядет, да, оставив меня в 2003?!");
				else
					Say("a","This shit is going to jail, yeah, leaving me in 2003?!");
				break;
			case 34:
				PlaySound(14);
				Show("aa","Центр");
				StartDissolve("aa",1);
				if(language==1)
					Say("aa","А почему она должна сесть? Почему не поверить, что ты нагнул пространственно-временной континуум и теперь стал настоящим русским Доктором Кто?");
				else
					Say("aa","Why should she sit down? Why not believe that you have bent the space-time continuum and now become a real Russian Doctor Who?");
				break;
			case 35:
				if(language==1)
					Think("Это вызывает улыбку адреналинового наркомана, которому проще, привычнее,  безопаснее думать, что всё это имеет конец и сила дана ему на 24 часа, на определённое число переходов, большую часть которых Андрей уже утратил, устраняя парадокс. ");
				else
					Think("This evokes the smile of an adrenaline junkie who finds it easier, more accustomed, safer to think that all this has an end and power is given to him for 24 hours, for a certain number of transitions, most of which Andrey has already lost, eliminating the paradox. ");
				break;
			case 36:
				EndDissolve("aa");
				if(language==1)
					Think("Он лезет рукой в карман и нащупывает там плеер, читает пальцами мелкие выбитые буковки, как слепой…");
				else
					Think("He reaches into his pocket and fumbles for the player, reads the small embossed letters with his fingers like a blind man…");
				break;
			case 37:
				Item(0);
				if(language==1)
					Think("Достает его и снова всматривается, словно стараясь просверлить в игрушке дыру. Вчитывается в буквы на обратной стороне. Всё те же предостережения: “сделано в Беларуси”, “в рот не совать”, “не мочить”.");
				else
					Think("Takes it out and peers again, as if trying to drill a hole in the toy. Read the letters on the reverse side. All the same warnings: “made in Belarus”, “do not put it in your mouth”, “do not wet it”.");
				break;
			case 38:
				if(language==1)
					Think("Ничего…");
				else
					Think("Nothing…");
				break;
			case 39:
				if(language==1)
					Think("Безумная идея, что среди предостережений для мам он увидит инструкцию к машине времени.");
				else
					Think("Crazy idea that among the warnings for moms, he will see the instructions for the time machine.");
				break;
			case 40:
				PlaySound(2);
				if(language==1)
					Think("В сердцах сжимает пластмассу до боли в ладони, и…");
				else
					Think("In his hearts he squeezes the plastic until it hurts in his palm, and…");
				break;
			case 41:
				Item(1);
				if(language==1)
					Think("На экран вздувается полоска.");
				else
					Think("A streak bulges onto the screen.");
				break;
			case 42:
				if(language==1)
					Think("Чертыхнувшись, перехватывает так, чтобы не касаться экрана, и перескакивает на следующую. Ведёт по экрану…");
				else
					Think(" Cursing, intercepts so as not to touch the screen, and jumps to the next one. Leads across the screen…");
				break;
			case 43:
				if(language==1)
					Say("a","Это ведь не сработает… Не сработает, да?");
				else
					Say("a","That won't work... won't work, will it?");
				break;
			case 45:
				yield return new WaitForEndOfFrame();
				if(gm.Stats["Root"]==1&&gm.Stats["Саня"]>2)
					NextCoroutine("G1A1",5);
				else if(gm.Stats["Root"]==2&&gm.Stats["Женя"]>2)
					NextCoroutine("G1A2",5);
				else if(gm.Stats["Root"]==0&&gm.Stats["Франческа"]>2)
					NextCoroutine("G1A3",5);
				else
					NextCoroutine("G1A4",5);
				break;
			case 44:
				Think("");
				DeactivateAllHeroes();
				Scene(6);
				PlayMusic(5);
				ChoiceList(
				new string[] { "Санина концовка","Женина концовка","Концовка Франчески","Нейтральная концовка" },
				new int[] { 5,5,5,5 },
				new string[] { "G1A1","G1A2","G1A3","G1A4" },
				new int[] { 0,0,0,0 });
				break;
			case 46:
				break;
			case 47:
				break;
			case 48:
				break;
			case 49:
				st.CanSkip(false);
				gm.act.CanTap=false;
				SetAllButtons(false);
				StopMusic();
				Item(3);
				PlaySound(11);
				yield return new WaitForSecondsRealtime(8f);
				Fade(5f,"Конец демо версии");
				yield return new WaitForSecondsRealtime(5f);
				SceneManager.LoadScene(0);
				break;
		}
		st.CoroutineEnding();
	}
}
