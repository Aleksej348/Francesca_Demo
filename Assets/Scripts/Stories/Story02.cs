using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Story02 : Story
{
	private IEnumerator D1A1()
	{
		st.CoroutineBegining();
		switch(st.step)
		{
			case 0:
				SetStats(new Dictionary<string,int> { { "Безумие",+1 },{ "Эскапизм",+1 },{ "Франческа",+1 } });
				Show("aa","Центр",new Vector3(-1f,1f,0));
				Move("aa","Центр","Лево",1f);
				StartDissolve("aa",0);
				yield return new WaitForSecondsRealtime(0.5f/speed);
				if(language==1)
					Say("aa","Да потому что…");
				else
					Say("aa","Yes because…");
				break;
			case 1:
				if(language==1)
					Say("aa","Сам-то как думаешь?",true,false);
				else
					Say("aa","What do you think?",true,false);
				break;
			case 2:
				Thrill("aa");
				PlaySound(14);
				if(language==1)
					Say("aa","*посмеивается*");
				else
					Say("aa","*chuckles*");
				break;
			case 3:
				if(language==1)
					Think("Сукачев отвечает, скучающе вертя в руках окурок — схлынули эмоции. ");
				else
					Think("Sukachev replies, twirling his cigarette butt in his hands in a bored voice — his emotions subsided. ");
				break;
			case 4:
				if(language==1)
					Say("a","Потому что нужно было меньше курить. ");
				else
					Say("a","Because I should have smoked less. ");
				break;
			case 5:
				Dissolve("aa",1);
				if(language==1)
					Say("aa","Ты бы не смог, наркоман хренов.");
				else
					Say("aa","You couldn't, you fucking junkie.");
				break;
			case 6:
				if(language==1)
					Think("Андрей чувствует фантомное дыхание на своей шее.");
				else
					Think("Andrew feels phantom breath on his neck.");
				Move("aa","Лево","Право",1f);
				yield return new WaitForSecondsRealtime(1f/speed);
				Mirror("aa",new Vector3(-1f,1f,0),new Vector3(1f,1f,0));
				break;
			case 7:
				Zoom("aa",new Vector3(1f,1f,0),new Vector3(2f,2f,0),1f);
				if(language==1)
					Say("aa","Живи…");
				else
					Say("aa","Live…");
				break;
			case 8:
				Zoom("aa",new Vector3(2f,2f,0),new Vector3(1f,1f,0),0.5f);
				if(language==1)
					Say("aa","СТРАДАЙ!");
				else
					Say("aa","SUFFER!");
				Shake();
				PlaySound(1);
				break;
			case 9:
				Dissolve("aa",0);
				if(language==1)
					Think("Сигаретный бычок мог бы прилететь понарошку в несуществующую рожу. Одним махом заткнуть навсегда — в отчёт на пробирающий до костей крик. Но вместо этого Андрей тушит его о пепельницу, даже не вздрогнув.");
				else
					Think("The cigarette butt could pretend to fly into a non-existent face. Shut up forever in one fell swoop - in response to a cry that cuts through to the bones. But instead Andrey puts it out on the ashtray without even flinching.");
				break;
			case 10:
				if(language==1)
					Say("a","Уже.",true,false);
				else
					Say("a","Already.",true,false);
				break;
			case 11:
				EndDissolve("aa");
				yield return new WaitForEndOfFrame();
				NextCoroutine("E1");
				break;
		}
		st.CoroutineEnding();
	}
	private IEnumerator D1A2()
	{
		st.CoroutineBegining();
		switch(st.step)
		{
			case 0:
				if(gm.Stats["Искренность"]<=0)
					SetStats(new Dictionary<string,int> { { "Безумие",+1 } });
				if(language==1)
					Think("Но вопрос этот, разумеется, риторический.");
				else
					Think("But this question is, of course, rhetorical.");
				break;
			case 1:
				if(language==1)
					Think("Так что вместо ответа Андрей просто выдыхает дым.");
				else
					Think("So instead of answering Andrey just exhales smoke.");
				break;
			case 2:
				yield return new WaitForEndOfFrame();
				NextCoroutine("E1");
				break;
		}
		st.CoroutineEnding();
	}
	private IEnumerator D1A3()
	{
		st.CoroutineBegining();
		switch(st.step)
		{
			case 0:
				SetStats(new Dictionary<string,int> { { "Саня",+1 },{ "Root",gm.Stats["Root"]==1 ? 0 : 1 } });
				st.step=1;
				goto case 1;
			case 1:
				if(language==1)
					Say("a","Да потому что должен же кто то его любить!",true,false);
				else
					Say("a","Yes, because someone must love him!",true,false);
				break;
			case 2:
				PlaySound(4);
				if(language==1)
					Think("Андрей лишь горько смеётся от этой своей истеричной мысли.");
				else
					Think("Andrey only laughs bitterly at this hysterical thought of his.");
				yield return new WaitForSecondsRealtime(0.1f);
				break;
			case 3:
				PlaySound(0);
				Thrill("a");
				if(language==1)
					Think("Смеётся, и тут же лезет в телефон, открывать диалог.");
				else
					Think("Laughs, and immediately reaches into the phone to open a dialogue.");
				break;
			case 4:
				if(language==1)
					Think("Но ничего не пишет.");
				else
					Think("But doesn't write anything.");
				break;
			case 5:
				if(language==1)
					Think("Зачем ему?");
				else
					Think("Why would he?");
				break;
			case 6:
				if(language==1)
					Think("Андрюше другое нужно — погуглить присланное Саньком видео, благо поиск теперь не только по картинкам есть.");
				else
					Think("Andryusha needs something else - to google the video sent by Sanko, since now there is a search not only by pictures. ");
				break;
			case 7:
				if(language==1)
					Think("Пара кликов и Сукачев в гугле.");
				else
					Think("A couple of clicks and Sukachev in Google.");
				break;
			case 8:
				gm.tw.WindowActive(true);
				if(language==1)
					Think("");
				else
					Think("");
				if(language==1)
					Text("\"Двадцатилетняя певица Анита Ли снова в центре скандала\"");

				else
					Text("\"Twenty-year-old singer Anita Lee again at the center of the scandal\"");
				break;
			case 9:
				if(language==1)
					Text("На слитом в сеть видео она режет себя ножом ради веселья и сообщает, что преданные фанаты смогут увидеть продолжение на её сольном концерте.");

				else
					Text("In the leaked video, she cuts herself with a knife for fun and announces that diehard fans will be able to see the sequel at her solo concert.");
				break;
			case 10:
				if(language==1)
					Text("Девушка, находясь в состоянии наркотического опьянения, пыталась разрезать кожаную юбку ножом, пародируя известного продюсера Александра Аспидова, “снявшего” таким образом косуху во время автограф-сессии его друга, известного исполнителя по кличке…  ");

				else
					Text("The girl, being in a state of drug intoxication, tried to cut a leather skirt with a knife, parodying the famous producer Alexander Aspidov, who thus \"removed\" the leather jacket during an autograph session of his friend, a famous performer named ... ");
				break;
			case 11:
				if(language==1)
					Text("Андрей помнит то знаменитое “почему не нужно покупать кожзам” — видео с Тулинского концерта, на котором “Александр” демонстрирует качество их мерча по сравнению с подаренной от рок легенды кожанкой.");

				else
					Text("Andrey remembers the famous \"why you don't need to buy leatherette\" - a video from the Tula concert, where \"Alexander\" demonstrates the quality of their merchandise compared to the leather jacket donated from the rock legend.");
				break;
			case 12:
				if(language==1)
					Text("Тогда он разрезал косуху ножом, ворвавшись на автограф-сессию из гримерки.");

				else
					Text("Then he cut the leather jacket with a knife, breaking into the autograph session from the dressing room.");
				break;
			case 13:
				if(language==1)
					Text("Должен был принести другу воды, но вместо этого сломал “штык-нож” об их мерч.");

				else
					Text("He was supposed to bring my friend some water, but instead I broke my bayonet on their merch.");
				break;
			case 14:
				if(language==1)
					Text("Сначала расторобанил косуху на потеху фанатам, потом — вытер ею пролитую на стол газировку. А в конце подсел к Илье, и упомянутый армейский штык-нож сломал, демонстрируя отвалившееся лезвие изумлённой толпе.");

				else
					Text("First, he squandered the leather jacket for the amusement of the fans, then wiped the soda spilled on the table with it. And in the end, he sat down with Ilya, and broke the aforementioned army bayonet-knife, demonstrating the fallen blade to the astonished crowd.");
				break;
			case 15:
				if(language==1)
					Text("Андрей то записанное на мыльницу видео из две тыщи девятого помнит покадрово, наизусть.");

				else
					Text("Andrey remembers the video recorded on the soapbox from two thousand nine frame by frame, by heart.");
				break;
			case 16:
				if(language==1)
					Text("Первый кадр. Илья — в той-самой-футболке — заканчивает расписываться на плакате и наклоняется к сидящей на месте Сани менеджеру, предлагая ей на выбор принести всем попить или сидеть расписываться за Илью, пока он сам ходит за напитками. ");

				else
					Text("First frame. Ilya - in the same T-shirt - finishes signing the poster and leans over to the manager, who is sitting in the seat, Sanya, offering her the choice of bringing everyone a drink or sitting to sign for Ilya while he himself goes for drinks. ");
				break;
			case 17:
				if(language==1)
					Text("Второй кадр. Менеджер подрывается, ныряет в толпу, на прощанье шепнув что-то Илье на ухо.");

				else
					Text("Second frame. The manager explodes, dives into the crowd, whispering something in Ilya's ear.");
				break;
			case 18:
				if(language==1)
					Text("Третий, четвёртый, пятый — Илья продолжает расписываться, очередь какой-то худенькой девушки — лезет обнять кумира, обнять покрепче. Из интересного там только взгляды, что ищут кого-то в толпе. Взгляды, какие бывают у плохого актёра, ожидающего конца скучной сценки, после которой наконец следует то, ради чего все собрались.");

				else
					Text("Third, fourth, fifth - Ilya continues to sign, it's the turn of some thin girl - climbs to hug the idol, hug her tightly. From the interesting there are only looks that they are looking for someone in the crowd. The looks that a bad actor has, waiting the end of a boring scene, after which finally follows what everyone has gathered for. ");
				break;
			case 19:
				if(language==1)
					Text("Порнуха начнётся! ");

				else
					Text("The porn will begin!");
				break;
			case 20:
				if(language==1)
					Text("Она и вправду начинается, когда из гримёрки выплывает Аспидов.");

				else
					Text("It really starts when Aspidov emerges from the dressing room.");
				break;
			case 21:
				if(language==1)
					Text("Отодвигая ботинком стул, он вальяжно заваливается, безо всякого стеснения раздвинув колени. Но так сидеть оказывается неудобно — Сане жмёт подаренная в знак признания кожанка. ");

				else
					Text("Pushing a chair aside with his boot, he collapses imposingly, spreading his knees without any embarrassment. But it turns out to be uncomfortable to sit like that - Sanya is squeezed by a leather jacket given as a token of recognition. ");
				break;
			case 22:
				if(language==1)
					Text("Ждёт недолго — вытащив из кобуры на бедре нож, он без зазрения совести дырявит куртку сбоку от молнии и скользит по ней лезвием под самый мерзкий на свете звук раздираемой кожи. Тут-то и выключается первая мыльница, но сразу же, буквально секунд через десять, запись продолжает другая. ");

				else
					Text("It doesn't take long - pulling a knife from a holster on his hip, he shamelessly pierces the jacket on the side of the zipper and slides along it with the blade to the most vile sound of torn skin in the world. This is where the first soap box turns off, but immediately, literally seconds after ten, another record continues. ");
				break;
			case 23:
				if(language==1)
					Text("Она снимает, как Саня встаёт и подходит к Илье, чтобы поддеть ножом воротник футболки. Все для того, чтобы рвануть со всей дури вниз, и тут же, как и полагается фокуснику, горделиво и артистично показать сломанный резак — армейский, крепкий, должный их всех пережить и помочь внучатам во время апокалипсиса, третьей мировой… ");

				else
					Text("She films how Sanya gets up and approaches Ilya to pry off the collar of his T-shirt with a knife. All in order to rush down with all the dope, and then, as befits a magician, proudly and artistically show a broken cutter - army, strong , due to survive them all and help the grandchildren during the apocalypse, the third world ... ");
				break;
			case 24:
				if(language==1)
					Text("Не суть. ");

				else
					Text("Not the point. ");
				break;
			case 25:
				if(language==1)
					Text("Суть — она в Сане");

				else
					Text("The essence is in Sana'a");
				break;
			case 26:
				if(language==1)
					Text("В его наиграно-искренней ухмылке. В нелепом, написанном на коленке \"рекламном\" тексте. В нервном \"я в этом не участвую\", так и не сорвавшемся с языка менеджера, утонувшей в первом в жизни косяке. В разоблачении, написанном сразу же, как морок перестал застилать карие, подведенные тушью глазки. В грубом, растасканном на перлы ответе Ильи. В разоблачении от старого рокера, утверждавшего, что это совсем не та косуха, которую он Сане по доброте душевной подогнал. В фотоответе от Сани, доказывающем, что — да, та самая. И в армейском ноже, и в девочке, сразу же отказавшейся от своего разоблачения с теми же затуманенными дурью глазами… ");

				else
					Text("In his fake-sincere smirk. In an absurd \"advertising\" text written on his knee. In a nervous \"I'm not involved in this\" that never escaped the manager's tongue, drowned in the first jamb in his life. In an exposé, written immediately, as the haze stopped obscuring his brown, ink-lined eyes, in Ilya’s rude, pearly answer, in an exposé from an old rocker, who claimed that this was not at all the leather jacket that he fitted Sanya out of the kindness of his soul. a photo response from Sanya, proving that - yes, the same one. And in an army knife, and in a girl who immediately refused her exposure with the same foolishly clouded eyes ... ");
				break;
			case 27:
				if(language==1)
					Text("Первое и последнее появление Аспидова на публике. ");

				else
					Text("Aspidov's first and last appearance in public.");
				break;
			case 28:
				if(language==1)
					Text("Дальше — только чужие гримёрки и смазанные фотки, слитые с тус \"только для своих\". Самим Аспидовым — фотки-то художественные, а Саня отличный фотограф. ");

				else
					Text("Then - only other people's dressing rooms and blurry pictures, merged from the party \"only for their own\". Aspidov himself - pictures are artistic, and Sanya is an excellent photographer. ");
				break;
			case 29:
				if(language==1)
					Text("Самый лучший.");

				else
					Text("The best one.");
				break;
			case 30:
				if(language==1)
					Text("Андрей говорит это с таким серьёзным выражением, что самому смешно, и смешно до колик. ");

				else
					Text("Andrey says this with such a serious expression that it's funny to himself, and funny to the point.");
				break;
			case 31:
				if(language==1)
					Text("А видео той певички?");

				else
					Text("And the video of that singer?");
				break;
			case 32:
				PlaySound(6);
				if(language==1)
					Text("Андрей наконец нажимает на пустое поле, печатает свой ответ. ");

				else
					Text("Andrey finally clicks on the empty field, prints his answer. ");
				break;
			case 33:
				gm.tw.WindowActive(false);
				PlaySound(0);
				Messenger(1,3);
				if(language==1)
					Say("АНДРЮША СУКАЧЕВ","50/50");
				else
					Say("ANDRYUSHA SUKACHEV","50/50");
				break;
			case 34:
				PlaySound(0);
				Messenger(1,4);
				if(language==1)
					Say("АНДРЮША СУКАЧЕВ","Здравствуйте! Чтобы посмотреть моё местоположение, выберите в меню \"отслеживать GPS\".");
				else
					Say("ANDRYUSHA SUKACHEV","Hello! To see my location, select \"track GPS\".");
				break;
			case 35:
				if(language==1)
					Think("И наблюдает, как приходит оповещение \"этот пользователь отслеживает ваш GPS, чтобы закрыть доступ, выберите в меню…\"");
				else
					Think("And watch as the alert arrives \"This user is tracking your GPS, to disable access, select from the menu…\"");
				break;
			case 36:
				if(language==1)
					Think("Андрею так хорошо, как не бывает от дури — потому что каждый приход после появления Сани обычно омрачается бэд трипом.");
				else
					Think("Andrey is as good as it can be from dope - because every arrival after the appearance of Sanya is usually overshadowed by a bad trip.");
				break;
			case 37:
				if(language==1)
					Think("Не самим, конечно, так — тенью, намёком, очередным Сукачевским заебом, от которого не спасает ни косячок, ни синтетика.");
				else
					Think("Not by ourselves, of course, like that - a shadow, a hint, another Sukachevsky fuck, from which neither a joint nor synthetics can save.");
				break;
			case 38:
				if(language==1)
					Think("А тут хорошо, пока не придет утро и не наступит ломка, потребность в Сане — даже воображаемом, даже безмолвно смотрящем на него с аватарки.");
				else
					Think("A it's good here until the morning comes and the breakdown comes, the need for Sana - even imaginary, even silently looking at him from the profile picture. ");
				break;
			case 39:
				if(language==1)
					Think("А пока — откинуться и закрыть глаза, блаженно улыбаясь, в то время, как дотлевает последняя сигарета.");
				else
					Think("In the meantime, lean back and close your eyes, smiling blissfully as the last cigarette dies down.");
				break;
			case 40:
				yield return new WaitForEndOfFrame();
				NextCoroutine("E1");
				break;
		}
		st.CoroutineEnding();
	}
	private IEnumerator E1()
	{
		st.CoroutineBegining();
		switch(st.step)
		{
			case 0:
				Fade(3f);
				yield return new WaitForSecondsRealtime(2f);
				Scene(0);
				st.SetMaterial(0,new Dictionary<string,float> { { "_WaveSpeed",2.5f },{ "_WaveAmplitude",0.01f } });
				PlayMusic(6);
				yield return new WaitForSecondsRealtime(2f);
				if(language==1)
					Think("Едва не тушит косяк об стол, но в последнее мгновение останавливается, резко одёргивая руку вниз, отчего пепел падает на голые колени — до крика.");
				else
					Think("Nearly extinguishes the joint on the table, but at the last moment stops, jerking his hand down, causing the ashes to fall on his bare knees - to the point of screaming.");
				PlaySound(7,0.9f);
				break;
			case 1:
				st.SetMaterial(0,new Dictionary<string,float> { { "_WaveSpeed",3f },{ "_WaveAmplitude",0.02f } });
				if(language==1)
					Think("Потому что там, где стояла пепельница, её нет.");
				else
					Think("Because where the ashtray was, there is none.");
				break;
			case 2:
				st.SetMaterial(0,new Dictionary<string,float> { { "_WaveSpeed",3.5f },{ "_WaveAmplitude",0.03f } });
				if(language==1)
					Think("Вместо неё на столе стоит тарелка с “пастой карбонара” —  тонкой, недоваренной, засохшей по краям — два дня назад он выбирал оттуда бекон… ");
				else
					Think("Instead, there is a plate of pasta carbonara on the table - thin, undercooked, dried around the edges - two days ago he picked bacon from there ... ");
				PlaySound(8);
				break;
			case 3:
				st.SetMaterial(0,new Dictionary<string,float> { { "_WaveSpeed",4f },{ "_WaveAmplitude",0.04f } });
				if(language==1)
					Think("Единственное, что ему удалось, хотя готовил трезвым, на вино не налегал ни до, ни после, в процессе — ");
				else
					Think(" The only thing he succeeded in, although he cooked sober, did not lean on wine either before or after, in the process - ");
				break;
			case 4:
				st.SetMaterial(0,new Dictionary<string,float> { { "_WaveSpeed",5f },{ "_WaveAmplitude",0.05f } });
				if(language==1)
					Say("a","Тоже, блять, нет!");
				else
					Say("a","Too fucking no!");
				break;
			case 5:
				st.SetMaterial(2,new Dictionary<string,float> { { "_LineWidth",0.05f } });
				if(language==1)
					Think("Андрей закрывает глаза — пульс набатом звенит в ушах, их закладывает. В горле тоже отдаётся: попробуй коснуться языком неба, сверни и запихай его в горло — дотянешься до предсердия! ");
				else
					Think("Andrey closes his eyes - the pulse rings in his ears like a tocsin, it fills them. In the throat, too, is given: try to touch the palate with your tongue, roll it up and shove it down your throat - you will reach the atrium! ");
				PlaySound(10);
				break;
			case 6:
				st.SetMaterial(2,new Dictionary<string,float> { { "_LineWidth",0.20f } });
				if(language==1)
					Say("a","Сучья... Ёбанная… Трава... Сука...");
				else
					Say("a","Bitch... Fucking... Grass... Bitch...");
				PlaySound(9);
				break;
			case 7:
				st.SetMaterial(1,new Dictionary<string,float> { { "_WaveSpeed",4f },{ "_WaveAmplitude",0.025f },{ "_IsHorizontalWave",1f },{ "_WaveLength",0.4f } });
				if(language==1)
					Think("Жмурится, приоткрывает глаза — тарелка, эта блядская тарелка всё ещё там!");
				else
					Think("Squints, opens eyes - plate, that fucking plate is still there!");
				break;
			case 8:
				PlaySound(1);
				Shake();
				if(language==1)
					Think("Бьет по столу кулаком с замахом: так, чтобы тарелка зазвенела, перевернулась и пропала к чёртовой матери!");
				else
					Think("Slams the table with his fist with a swing: so that the plate rattles, turns over and disappears to hell!");
				yield return new WaitForSecondsRealtime(0.3f);
				st.SetMaterial(1,new Dictionary<string,float> { { "_WaveSpeed",8f },{ "_WaveAmplitude",0.05f } });
				break;
			case 9:
				st.SetMaterial(1,new Dictionary<string,float> { { "_WaveSpeed",9f },{ "_WaveAmplitude",0.07f } });
				if(language==1)
					Think("Тарелка в ответ на удар послушно и с грохотом переворачивается, и лапша склизким соусом валится на стол.");
				else
					Think("The plate flips obediently and with a crash in response to the blow, and the noodles fall on the table like a slimy sauce.");
				break;
			case 10:
				st.SetMaterial(1,new Dictionary<string,float> { { "_WaveSpeed",10f },{ "_WaveAmplitude",0.1f } });
				PlaySound(8);
				if(language==1)
					Think("Андрей захлёбывается болью, костяшки простреливает, угол проходится до кости и врезается в мясо, но дурацкая пьяная упёртость мешает закричать.");
				else
					Think("Andrei chokes on pain, shoots through his knuckles, the corner goes to the bone and crashes into the meat, but stupid drunken obstinacy prevents him from screaming.");
				break;
			case 11:
				st.SetMaterial(1,new Dictionary<string,float> { { "_WaveSpeed",4f },{ "_WaveAmplitude",0.025f } });
				if(language==1)
					Think("Мешает упёртость, а ещё мешает мысль, что вселенная схлопнется, если местный “Андрюша”, который должен сейчас быть в отрубе на кухне, прибежит на крик, и они встретятся.");
				else
					Think("Stubbornness gets in the way, and the thought that the universe will collapse if the local “Andryusha”, who should now be in the cut in the kitchen, comes running to the cry, and they will meet.");
				break;
			case 12:
				Show("aa","Право");
				StartDissolve("aa",0);
				if(language==1)
					Say("aa","Какую гадость, Андрюша, ты думаешь. Сидишь и глазеешь в никуда, угашенный…");
				else
					Say("aa","What a mess, Andryusha, you think. You sit and stare into nowhere, extinguished ... ");
				break;
			case 13:
				if(language==1)
					Say("aa","Какая ебланская эта твоя идея, что ты переместился в прошлое, Андрюш.",true,false);
				else
					Say("aa","What a fucking idea of \u200b\u200byours that you moved into the past, Andryush.",true,false);
				break;
			case 14:
				Move("aa","Право","Лево",1f);
				EndDissolve("aa");
				st.SetMaterial(1,new Dictionary<string,float> { { "_WaveSpeed",4f },{ "_WaveAmplitude",0.02f },{ "_IsHorizontalWave",0 },{ "_WaveLength",0.4f } });
				PlaySound(7);
				if(language==1)
					Think("Он вскакивает, запинается о стул и чудом остаётся стоять на ногах, пока здоровой рукой яростно не толкает стул и не несётся в туалет блевать.");
				else
					Think("He jumps up, stumbles over the chair, and miraculously stays on his feet until he violently pushes the chair with his good hand and rushes to the toilet to puke.");
				break;
			case 15:
				st.SetMaterial(1,new Dictionary<string,float> { { "_WaveSpeed",5f },{ "_WaveAmplitude",0.03f },{ "_IsHorizontalWave",0 },{ "_WaveLength",0.5f } });
				if(language==1)
					Think("Но там лишь надрывно кашляет и, весь раскрасневшийся, грузной тенью, мрачнее тучи возвращается в свою комнату, где ждет…");
				else
					Think("But there he only coughs hysterically and, all flushed, a heavy shadow, gloomier than a cloud, returns to his room, where he waits ... ");
				PlaySound(9);
				break;
			case 16:
				st.SetMaterial(1,new Dictionary<string,float> { { "_WaveSpeed",6f },{ "_WaveAmplitude",0.04f },{ "_IsHorizontalWave",0 },{ "_WaveLength",0.6f } });
				if(language==1)
					Think("Стул — отъехавший по ковру, лапша — там же, где её оставил… ");
				else
					Think("Chair - rolled over the carpet, noodles - right where you left them... ");
				break;
			case 17:
				PlaySound(9);
				if(language==1)
					Think("От этой картины его снова тянет выплюнуть содержимое легких, очиститься от примесей крови. ");
				else
					Think("This picture makes him want to spit out the contents of his lungs again, to cleanse himself of blood impurities. ");
				break;
			case 18:
				if(language==1)
					Think("Мышка висит на проводе, красный мигает. На шум никто не прибежал. ");
				else
					Think("Mouse hanging on a wire, red blinking. No one came running to the noise. ");
				break;
			case 19:
				Show("aa","Лево",new Vector3(-1f,1f,0));
				StartDissolve("aa",0);
				if(language==1)
					Say("aa","Да потому, Андрюша, что некому бежать. Так, видно, и сдохнешь: один, в соплях, отравившись шишками; и этот маленький мирок в укуре станет домом твоего потухшего разума. ");
				else
					Say("aa","Yes, Andryusha, because there is no one to run. So, apparently, you will die: alone, in snot, poisoned by cones; and this little world in a stone will become the home of your extinct mind. ");
				break;
			case 20:
				if(language==1)
					Say("aa","Пара минуток позавчерашнего дня — твоя могила. Бессмертная душа вот-вот покинет тело, и боженька выключит тебе свет, низвергнет в ад, натянет на колесо сансары...",true,false);
				else
					Say("aa","A couple of minutes the day before yesterday is your grave. The immortal soul is about to leave the body, and God will turn off the light for you, cast you into hell, pull you onto the wheel of samsara...",true,false);
				break;
			case 21:
				EndDissolve("aa");
				if(language==1)
					Think("Руки тянутся к глазам, прячет лицо в ладонях, но стагнация не может длиться вечно. Приходится открыть глаза и уговорить себя по шажочку двигаться на кухню…");
				else
					Think("Hands reach for eyes, face in hands, but stagnation cannot last forever. I have to open my eyes and talk myself into stepping into the kitchen…");
				break;
			case 22:
				if(language==1)
					Think("…А потом плюнуть на всё и бежать туда вприпрыжку, раздражая соседку снизу шумом после десяти!");
				else
					Think("…And then spit on everything and run there skipping, annoying the neighbor downstairs with noise after ten!");
				break;
			case 23:
				if(language==1)
					Think("Чтобы старушка дотянулась до батареи и стуком по ней разбудила несуществующего прикорнувшего на кухне Андрея из прошлого. ");
				else
					Think("For the old woman to reach out to the radiator and tap on it to wake up the non-existent Andrey from the past, crouched in the kitchen. ");
				break;
			case 24:
				st.SetMaterial(1,new Dictionary<string,float> { { "_WaveSpeed",6f },{ "_WaveAmplitude",0.04f },{ "_IsHorizontalWave",0 },{ "_WaveLength",0.6f } });
				if(language==1)
					Think("Андрей настоящий бросает взгляд на игрушку, катализатор бэд-трипа. ");
				else
					Think("The real Andrey glances at the toy, the catalyst for a bad trip. ");
				break;
			case 25:
				st.SetMaterial(1,new Dictionary<string,float> { { "_WaveSpeed",5f },{ "_WaveAmplitude",0.03f },{ "_IsHorizontalWave",0 },{ "_WaveLength",0.5f } });
				if(language==1)
					Think("На дисплее снова что-то мерещится. Правда теперь уже — точно цифры.");
				else
					Think("The display shows something else. The truth is now already - just numbers. ");
				break;
			case 26:
				st.SetMaterial(1,new Dictionary<string,float> { { "_WaveSpeed",4f },{ "_WaveAmplitude",0.02f },{ "_IsHorizontalWave",0 },{ "_WaveLength",0.4f } });
				Item(2);
				if(language==1)
					Think("24.11.2020 ");
				else
					Think("24.11.2020 ");
				break;
			case 27:
				Show("aa","Центр");
				StartDissolve("aa",0);
				if(language==1)
					Say("aa","А с чего ты, собственно, решил, что на кухне никого нет? Если тебя так кроет, что тарелки несуществующие опрокидываешь, то почему там не быть второму Андрею? ");
				else
					Say("aa","Why do you think there is no one in the kitchen? If you are so covered that you knock over non-existent plates, then why shouldn't the second Andrey be there? ");
				break;
			case 28:
				if(language==1)
					ChoiceList(
					new string[] { "Отличная идея!","Нет" },
					new int[] { 2,2 },
					new string[] { "E1A1","E1A2" },
					new int[] { 0,0 },
					new bool[] { true,true },
					new string[]{"<color=#FF00D1>Безумие</color>+1,<color=#32E9AB>Эскапизм</color>+1\r\nЕсли <color=#6AEC49>Франческа</color><=0,\r\nто <color=#FF00D1>Безумие</color>++2\r\nЕсли <color=#6AEC49>Франческа</color>>0\r\nто <color=#6AEC49>Франческа</color>++1",
			"<color=#FF00D1>Безумие</color>-1,\r\n<color=#A8FFFC>Искренность</color>+1"});
				else
					ChoiceList(
					new string[] { "Great idea!","No" },
					new int[] { 2,2 },
					new string[] { "E1A1","E1A2" },
					new int[] { 0,0 },
					new bool[] { true,true },
					new string[]{"<color=#FF00D1>Madness</color>+1,<color=#32E9AB>Escapism</color>+1\r\nIf <color=#6AEC49>Francesca</color><= 0,\r\nthen <color=#FF00D1>Madness</color>++2\r\nIf <color=#6AEC49>Francesca</color>>0\r\nthen <color=#6AEC49>Francesca</color>++1",
			"<color=#FF00D1>Madness</color>-1,\r\n<color=#A8FFFC>Sincerity</color>+1"});
				break;
			case 29:
				break;
		}
		st.CoroutineEnding();
	}
	private IEnumerator E1A2()
	{
		st.CoroutineBegining();
		switch(st.step)
		{
			case 0:
				EndDissolve("aa");
				SetStats(new Dictionary<string,int> { { "Безумие",-1 },{ "Искренность",+1 } });
				st.SetMaterial(0,new Dictionary<string,float> { { "_WaveSpeed",4f },{ "_WaveAmplitude",0.04f } });
				if(language==1)
					Think("У шкафа появляются открытые дверцы с зеркалами, а сам он уже становится обклеенной светло-коричневой клейкой лентой, с заплатками на углах.");
				else
					Think("The closet has open doors with mirrors and is already covered in light brown duct tape with patches on the corners.");
				break;
			case 1:
				TimeTravel("Квартира Андрея: Комната 1981",3,8);
				yield return new WaitForSecondsRealtime(12f/speed);
				break;
			case 2:
				SetAllButtons(true);
				Show("Девочка","Лево");
				StartDissolve("Девочка",0);
				if(language==1)
					Say("girl","Мам, почему оно так осыпается? Все пайетки опадут, и я буду самой облезлой снежинкой, как и говорил папа!");
				else
					Say("girl","Mom, why is it crumbling like that? All the sequins will fall off, and I will be the most shabby snowflake, just like daddy said! ");
				break;
			case 3:
				Show("Женщина","Право");
				StartDissolve("Женщина",0);
				if(language==1)
					Say("woman","Ничего, сейчас что-нибудь придумаем, не переживай. Хорошо, что мы заранее его проверили. Только чтобы больше я не слышала, как ты повторяешь за папой. Он ляпнет, не подумав, а ты…");
				else
					Say("woman","Nothing, we'll think of something now, don't worry. It's good that we checked it in advance. Just so I don't hear you repeating after dad again. He will blurt out without thinking, and you ... ");
				break;
			case 4:
				if(language==1)
					Think("Женщина говорит из его комнаты, пока Андрей поворачивает к свету зажатый в ладони плеер — на курок соскользнул палец с правой лопасти.");
				else
					Think("The woman speaks from his room as Andrey turns the player in his palm towards the light - a finger slipped off the trigger from the right blade.");
				break;
			case 5:
				Item(4);
				if(language==1)
					Think("25.12.1981");
				else
					Think("25.12.1981");
				break;
			case 6:
				if(language==1)
					Think("У девочки коротко подстриженные чёрные волосы, как у Алисы Селезневой, и белое платье, сверкающее лиловым каждой пришитой пайеткой на подоле. ");
				else
					Think(" The girl has short cut black hair, like Alisa Selezneva, and a white dress that sparkles purple with every sequin sewn on the hem. ");
				break;
			case 7:
				if(language==1)
					Think("По лифу снегопад из снежинок, отражаясь в самом уголке зеркала и преломляясь, распадается тысячами малиновых осколков.");
				else
					Think("Across the bodice, a snowfall of snowflakes, reflected in the very corner of the mirror and refracted, disintegrates into thousands of crimson fragments.");
				break;
			case 8:
				if(language==1)
					Think("Картинка сменяется так стремительно, что Андрюша просто не успевает среагировать, вцепиться в плеер и исчезнуть в позавчера.");
				else
					Think("The picture changes so fast that Andryusha just doesn't have time to react, grab the player and disappear into the day before yesterday.");
				break;
			case 9:
				Move("Женщина","Право","Центр",1f);
				if(language==1)
					Think("Девочку обходит женщина с выгоревшими от краски волосами, на вид ломкими, как жухлая трава. Женщина просит девочку поднять руки, чтобы снять платье. Так медленно, неторопливо и плавно ткань скользит по коже. ");
				else
					Think(" The girl is passed by a woman with dye-bleached hair that looks as brittle as withered grass. The woman asks the girl to raise her hands to take off her dress. So slowly, leisurely and smoothly, the fabric glides over the skin. ");
				break;
			case 10:
				if(language==1)
					Think("Сукачев теряется, смотрит пространно. Катастрофа всё ближе с каждым новым миллиметром открывшейся кожи.");
				else
					Think("Sukachev is at a loss, looking vaguely. The catastrophe is getting closer with each new millimeter of exposed skin.");
				break;
			case 11:
				if(language==1)
					Think("Девочка мотает головой и приглаживает наэлектризованные волосы, но их не получается уложить.");
				else
					Think("The girl shakes her head and smoothes her electrified hair, but it can't be styled.");
				break;
			case 12:
				if(language==1)
					Think("И тут она замирает, смотря прямо Андрею в глаза. ");
				else
					Think("And then she freezes, looking directly into Andrey's eyes. ");
				break;
			case 13:
				PlaySound(12,1f,true);
				if(language==1)
					Think("Детский крик, от которого закладывает уши, — истекло время, и последняя песчинка срывается, скатывается с горки и застывает там на вечность.");
				else
					Think("A child's cry that fills the ears - time has run out, and the last grain of sand breaks, rolls down the hill and freezes there for eternity.");
				break;
			case 14:
				PlayMusic(9,true);
				Move("Девочка","Лево","Центр",1f,Vector3.zero,new Vector3(-3.5f,0,0));
				if(language==1)
					Think("Андрей лезет рукой за плеером, пальцем нащупывает плюс и нажимает, щёлкает со всей силы, пока женщина поворачивается на крик дочери и бросается к телефону, спотыкается о провод, падает и орёт во всё горло");
				else
					Think("Andrey reaches behind the player, finds a plus with his finger and presses, clicks with all his might, while the woman turns at her daughter's cry and rushes to the phone, stumbles over the wire, falls and yells at the top of her throat ");
				break;
			case 15:
				if(language==1)
					Think("Девочка поворачивается к маме, в глазах стоят слезы, а зрачки сужены от страха.");
				else
					Think("The girl turns to her mother, her eyes filled with tears and her pupils constricted with fear.");
				break;
			case 16:
				if(language==1)
					Think("Ребёнка трясёт, она пытается встать и кинуться к маме, но шок парализует маленькое тело, заставляя беспомощно дрожать, задыхаться в рыданиях. Холод обжигает до боли, до холодного пота.");
				else
					Think("The baby is shaking, she tries to get up and rush to her mother, but the shock paralyzes her small body, making her tremble helplessly, suffocate in sobs. The cold burns to the point of pain, to a cold sweat.");
				break;
			case 17:
				if(language==1)
					Say("woman","Я ЗВОНЮ В ПОЛИЦИЮ! АНЯ!!! ",true);
				else
					Say("woman","I'M CALLING THE POLICE! ANIA!!! ",true);
				break;
			case 18:
				Thrill("Девочка");
				if(language==1)
					Say("girl","Мама, может, он друг хозяйки? ");
				else
					Say("girl","Mom, maybe he is a friend of the hostess? ");
				break;
			case 19:
				if(language==1)
					Think("Девочка говорит очень тихо и окончание проглатывает. Карие глаза блестят от слез, ресницы склеились, а на покрасневших влажных щеках никак не засохнет соль.");
				else
					Think("The girl speaks very quietly and swallows the ending. Hazel eyes are glistening with tears, eyelashes are glued together, and salt will never dry on reddened, wet cheeks.");
				break;
			case 20:
				if(language==1)
					Think("Андрей поднимает руки вверх — не может этого выносить. Срывающийся голос проходится по натянутым как струна нервам.");
				else
					Think("Andrey puts his hands up - he can't stand it. A crackling voice runs through nerves that are strained like a string.");
				break;
			case 21:
				if(language==1)
					Think("Но продолжает с надеждой ковыряться ногтем — кнопку надеется поддеть, зацепить, сбежать хоть в следующий год. Или в предыдущий.");
				else
					Think("But he continues to hopefully pick his fingernail - he hopes to pry the button, hook it, run away at least next year. Or to previous.");
				break;
			case 22:
				if(language==1)
					Think("Всего-то нужно пару минут тишины без ора, крика и вязкого страха — не пугать до икоты женщин и детей.");
				else
					Think("All you need is a couple of minutes of silence without yelling, screaming and viscous fear - not to scare women and children to hiccups.");
				break;
			case 23:
				if(language==1)
					Think("Один год назад погоды не сделает: как был нищим маяком для спецслужб, так и остался. Со своими кислотными волосами, джинсами и смартфоном. В лучшем случае окажется в психбольнице, где ему пожертвуют галоперидола, достаточного для отключки.");
				else
					Think("One year ago the weather won't make it: as it was a beggar beacon for the special services, it has remained so. With his acid hair, jeans and smartphone. At best, he will end up in a mental hospital, where he will be donated haloperidol, enough to pass out. ");
				break;
			case 24:
				Show("aa","Лево",new Vector3(-1f,1f,0));
				StartDissolve("aa",0);
				EndDissolve("Женщина");
				EndDissolve("Девочка");
				if(language==1)
					Say("aa","А то, что это может создать парадокс? Что будущее изменится из-за встречи с реальными людьми?");
				else
					Say("aa","A that it can create a paradox? That the future will change because of meeting real people?");
				break;
			case 25:
				if(language==1)
					Say("aa","Или породить легенду о проклятой квартире с призраком нарка, появляющимся каждый год…",true,false);
				else
					Say("aa","Or spawn a legend about a cursed apartment with a narc ghost appearing every year…",true,false);
				break;
			case 26:
				Move("aa","Лево","Право",1f);
				EndDissolve("aa");
				if(language==1)
					Think("Но ничто не останавливает Андрея: старается попасть пальцем посередине. Всё ещё неуверенный, правда, что после этого обретет вожделенную тишину.");
				else
					Think("But nothing stops Andrey: he tries to get his finger in the middle. Still unsure, though he'll find the silence he longs for after this.");
				break;
			case 27:
				if(language==1)
					Think("И женщина кричит ему вдогонку, прежде чем раствориться в темноте с тихим храпом…");
				else
					Think("And the woman yells after him before disappearing into the darkness with a soft snore…");
				break;
			case 28:
				yield return new WaitForEndOfFrame();
				NextCoroutine("E1A2B1",3);
				break;
		}
		st.CoroutineEnding();
	}
	private IEnumerator E1A1()
	{
		st.CoroutineBegining();
		switch(st.step)
		{
			case 0:
				EndDissolve("aa");
				if(gm.Stats["Франческа"]<=0)
					SetStats(new Dictionary<string,int> { { "Безумие",+3 },{ "Эскапизм",+1 } });
				else
					SetStats(new Dictionary<string,int> { { "Безумие",+1 },{ "Эскапизм",+1 },{ "Франческа",+1 } });
				st.SetMaterial(1,new Dictionary<string,float> { { "_WaveSpeed",4f },{ "_WaveAmplitude",0.04f } });
				if(language==1)
					Think("У шкафа появляются открытые дверцы с зеркалами, а сам он уже становится обклеенной светло-коричневой клейкой лентой, с заплатками на углах.");
				else
					Think("The closet has open doors with mirrors and is already covered in light brown duct tape with patches on the corners.");
				break;
			case 1:
				TimeTravel("Квартира Андрея: Комната 1986",4,5);
				yield return new WaitForSecondsRealtime(12f/speed);
				break;
			case 2:
				SetAllButtons(true);
				if(language==1)
					Think("В эти леденящие затухающие звуки Андрей перемещается из коридора в комнату.");
				else
					Think("At these chilling fading sounds Andrey moves from the hallway into the room.");
				break;
			case 3:
				if(language==1)
					Think("Но перед ним теперь почти ничего нет — одно заляпанное сотнями отпечатков наркоманов окно и занавески.");
				else
					Think("But now there is almost nothing in front of him - one window and curtains stained with hundreds of prints of drug addicts.");
				break;
			case 4:
				if(language==1)
					Think("Занавески кто-то поджёг, отчего кружево обуглилось. И без того оно было похоже на крылья моли, а сейчас и вовсе стало напоминать то, что остаётся от бабочки, если к ней поднести отцовскую зажигалку. ");
				else
					Think("The curtains were set on fire, causing the lace to char. Even without that, it looked like the wings of a moth, and now it has completely begun to resemble what remains of a butterfly if you bring your father's lighter to it. ");
				break;
			case 5:
				Show("a","Лево",new Vector3(-1f,1f,0));
				StartDissolve("a",0);
				if(language==1)
					Say("a","Такой же бледной и была. Уродливой... ");
				else
					Say("a","She was just as pale. Ugly... ");
				break;
			case 6:
				if(language==1)
					Think("Андрей, сражённый в самое сердце, подходит только за тем, чтобы нежно приласкать мотыльковые крылышки.");
				else
					Think("Andrey, smitten in the heart, comes only to gently caress the butterfly wings.");
				break;
			case 7:
				Thrill("a");
				PlaySound(2);
				if(language==1)
					Think("И вот он уже доходит до окна с грязным подоконнико  и неприятно ногой задевает что-то лёгкое, пластмассовое —");
				else
					Think("And now he reaches the window with a dirty sill and unpleasantly touches something light, plastic with his foot —");
				break;
			case 8:
				Thrill("a");
				PlaySound(2);
				if(language==1)
					Think("Шприц. И носочком припирает его к стене. ");
				else
					Think("Syringe. And pins him to the wall with his toe. ");
				break;
			case 9:
				if(language==1)
					Think("Заворожённый чертит указательным пальцем завитушку. Вблизи она неприятно-желтоватая, нет и намека на нужный красивой бабочке снежно-белый. ");
				else
					Think("Bewitched draws a swirl with his index finger. Up close, it is unpleasantly yellowish, there is not even a hint of the snow-white necessary for a beautiful butterfly. ");
				break;
			case 10:
				if(language==1)
					Say("a","А ты у меня умница, да? ");
				else
					Say("a","Are you smart, right? ");
				break;
			case 11:
				if(language==1)
					Say("a","Умеешь выбирать красивые интерьеры любимому торчку…");
				else
					Say("a","You know how to choose beautiful interiors for your favorite junkie…");
				break;
			case 12:
				if(language==1)
					Say("a"," Я же твой любимый торчок?",true);
				else
					Say("a"," Am I your favorite junkie?",true);
				break;
			case 13:
				Show("aa","Право");
				StartDissolve("aa",0);
				if(language==1)
					Say("aa","И вправду прекрасные декорации из дыма анаши.");
				else
					Say("aa","Really nice marijuana smoke decorations.");
				break;
			case 14:
				Dissolve("aa",1);
				if(language==1)
					Say("aa","Танцуют тебя, как хотят, делают своим креслицем и садятся на тебя с ногами.",true);
				else
					Say("aa","They dance you as they want, make you their armchair and sit on you with their feet.",true);
				break;
			case 15:
				if(language==1)
					Say("a","Декорации танцуют?");
				else
					Say("a","The scenery is dancing?");
				break;
			case 16:
				if(language==1)
					Say("a","Вот я и нашёл твой главный баг.",true);
				else
					Say("a","So I found your main bug.",true);
				break;
			case 17:
				Dissolve("aa",0);
				if(language==1)
					Say("a","Мозг-то у нас с тобой на двоих один.");
				else
					Say("a","The brain is one for two of us.");
				break;
			case 18:
				if(language==1)
					Say("a","И я его накурил.");
				else
					Say("a","And I smoked it.");
				break;
			case 19:
				PlaySound(4);
				if(language==1)
					Think("*смеется*");
				else
					Think("*laughs*");
				break;
			case 20:
				if(language==1)
					Say("a","Хуёво быть тульпой!",true);
				else
					Say("a","It sucks to be a tulpa!",true);
				break;
			case 21:
				if(language==1)
					Think("Не дожидаясь ответа, подносит  плеер к носу так, чтобы видно было экран.");
				else
					Think("Without waiting for an answer, brings the player to the nose so that the screen can be seen.");
				break;
			case 22:
				Item(5);
				if(language==1)
					Think("27.11.1986");
				else
					Think("11/27/1986");
				break;
			case 23:
				if(language==1)
					Think("Вторая рука по прежнему на занавеске");
				else
					Think("Second hand still on curtain");
				break;
			case 24:
				if(language==1)
					Think("Без цели постукивает пальцем по кружеву, проводит по цифрам пальцем и случайно соскальзывает на пустой картон, проводя линию, и тут слышит женское хихиканье.");
				else
					Think("Aimlessly taps his finger on the lace, traces the numbers with his finger, and accidentally slips onto an empty cardboard, drawing a line, and then he hears a woman's giggle.");
				break;
			case 25:
				EndDissolve("aa");
				Move("aa","Право","Центр",1f);
				EndDissolve("a");
				Move("a","Лево","Центр",1f);
				if(language==1)
					Say("Наркоманка","Блять, сиги кончились, ну дай по-братски!");
				else
					Say("Junkie","Blyat, whitefish are over, well, give it like a brother!");
				break;
			case 26:
				if(language==1)
					Think("И Голос, доносящийя из соседний комнаты.");
				else
					Think("And A voice coming from the next room.");
				break;
			case 27:
				if(language==1)
					Think("Дверь в ту комнату приоткрыта, и Андрей может видеть танцующие по полу тени в усмерть пьяных тел. ");
				else
					Think("The door to that room is ajar, and Andrey can see shadows dancing across the floor into deathly drunken bodies. ");
				break;
			case 28:
				if(language==1)
					Say("Еще одна наркоманка","Чего там тебе дать, а? И не дыши на меня, перегаром воняешь.");
				else
					Say("Another drug addict","What can I give you, huh? And don't breathe on me, you stink of fumes.");
				break;
			case 29:
				if(language==1)
					Think("В комнате мебель застелена клеенкой, в советском шкафу нет ни фарфора, ни сервиза — все, что могли, две блондинки вынесли.");
				else
					Think("The furniture in the room is covered with oilcloth, there is no china or service in the Soviet closet - everything they could, the two blondes took out.");
				break;
			case 30:
				if(language==1)
					Think("И шкаф…");
				else
					Think("And the closet…");
				break;
			case 31:
				if(language==1)
					Think("А что шкаф?");
				else
					Think("What's the closet?");
				break;
			case 32:
				if(language==1)
					Think("Шкаф слишком тяжёлый для исколотых рук.");
				else
					Think("The wardrobe is too heavy for pricked hands.");
				break;
			case 33:
				if(language==1)
					Say("Еще одна наркоманка","Сама знаешь.");
				else
					Say("Another junkie","You know.");
				break;
			case 34:
				if(language==1)
					Say("Наркоманка","И будто ты не воняешь. ");
				else
					Say("Drug Addict","And if you don't stink. ");
				break;
			case 35:
				if(language==1)
					Say("Наркоманка","Обидно ей.");
				else
					Say("Junkie","Shame on her.");
				break;
			case 36:
				if(language==1)
					Think("Шёпот прекращается, криком разносится вдогонку: “а ты не ори, старая блядь!”.");
				else
					Think("The whispering stops, a shout echoes after: “don't you yell, you old whore!”.");
				break;
			case 37:
				if(language==1)
					Think("“Старой бляди” нет и двадцати, как и девушке, смертельно на неё обиженной. Но чтобы это увидеть, нужно заглянуть за порог, а Андрей всё стоит, любуется. ");
				else
					Think("“The old whore” is not even twenty, like the girl who is mortally offended by her. But to see it, you need to look over the threshold, and Andrei is still standing, admiring. ");
				break;
			case 38:
				if(language==1)
					Think("Грохот опрокидывающегося на пол стула и покатившейся по полу пепельницы, что на этом стуле стояла. ");
				else
					Think(" The sound of a chair tipping over onto the floor and the ashtray that sat on that chair rolling across the floor. ");
				break;
			case 39:
				PlaySound(13,0.7f);
				if(language==1)
					Think("Снова хохот. ");
				else
					Think("Laughter again. ");
				break;
			case 40:
				if(language==1)
					Say("Наркоманка","Да куда ты его сунула?!");
				else
					Say("Junkie","Where did you put it?!");
				break;
			case 41:
				if(language==1)
					Think("Шорох и тихое “блядь, не могу найти”.");
				else
					Think("Rustle and quiet “fuck I can't find it”.");
				break;
			case 42:
				if(language==1)
					Say("Наркоманка","Ну все, пиздец ковру.");
				else
					Say("Drug Addict","That's it, fuck the carpet.");
				break;
			case 43:
				PlaySound(13,0.7f);
				if(language==1)
					Think("Снова смех.");
				else
					Think("Laughter again.");
				break;
			case 44:
				if(language==1)
					Say("Еще одна наркоманка","Да поебать! Не видишь что ли, что я ищу! Не можешь помочь — не мешай. ");
				else
					Say("Another junkie","Fuck it! Can't you see what I'm looking for! If you can't help, don't interfere. ");
				break;
			case 45:
				Show("aa","Лево",new Vector3(-1f,1f,0));
				StartDissolve("aa",0);
				if(language==1)
					Say("aa","И снова — смех, смех, смех…");
				else
					Say("aa","And again - laughter, laughter, laughter ... ");
				break;
			case 46:
				if(language==1)
					Say("aa","Хорошо ж смеются?");
				else
					Say("aa","Good laugh?");
				break;
			case 47:
				if(language==1)
					Say("aa","Задорно! Так и хочется присоединится…");
				else
					Say("aa","Cherky! I just want to join…");
				break;
			case 48:
				if(language==1)
					Say("aa","Да только суки они.");
				else
					Say("aa","Yes, but they are bitches.");
				break;
			case 49:
				Dissolve("aa",1);
				if(language==1)
					Say("aa","А ДАВАЙТЕ ПОМОЖЕМ ДВУМ СУКАМ НАЙТИ ГЕРОИНОВЫЙ ШПРИЦ?!");
				else
					Say("aa","LET'S HELP THE TWO BITCHES FIND A HEROIN SYRINGE?!");
				break;
			case 50:
				if(language==1)
					Say("aa","ХОТЯ Я ЕГО УЖЕ НАШЁЛ, НЕ БЛАГОДАРИ.",true);
				else
					Say("aa","EVEN I ALREADY FOUND IT, DONT THANK YOU.",true);
				break;
			case 51:
				Dissolve("aa",0);
				if(language==1)
					Say("aa","Не благодари.");
				else
					Say("aa","Don't thank.");
				break;
			case 52:
				Thrill("aa");
				PlaySound(2);
				if(language==1)
					Think("Красуясь, указывает на искомый шприц правым кроссовком, а сам смеётся — так же отвратительно, как две наркоманки. ");
				else
					Think(" Showing off, he points to the desired syringe with his right sneaker, while he himself laughs - as disgusting as two drug addicts. ");
				break;
			case 53:
				if(language==1)
					Say("a","Сам подавай.");
				else
					Say("a","Give it yourself.");
				break;
			case 54:
				if(language==1)
					Say("a","Подал? ");
				else
					Say("a","Submitted? ");
				break;
			case 55:
				if(language==1)
					Say("a","Теперь пойдём, надоело тут торчать.");
				else
					Say("a","Now let's go, tired of hanging around here.");
				break;
			case 56:
				if(language==1)
					Say("a","Скучно.");
				else
					Say("a","Boring.");
				break;
			case 57:
				if(language==1)
					Think("Андрей вдыхает пропитанный дурью и подпаленной занавеской воздух — не чета всему тому, что курит сам, а на картонке прорисовывается… ");
				else
					Think("Andrey inhales the air saturated with dope and scorched by the curtain - not like everything that he smokes himself, but on the cardboard it is drawn ... ");
				EndDissolve("aa");
				Move("aa","Лево","Центр",1f);
				break;
			case 58:
				Item(6);
				if(language==1)
					Think("1 — 00");
				else
					Think("1 - 00");
				break;
			case 59:
				if(language==1)
					Think("Картонка так близко, что едва не утыкается в нос. ");
				else
					Think("The cardboard is so close that it almost touches the nose. ");
				break;
			case 60:
				if(language==1)
					Say("a","Почти готово");
				else
					Say("a","Almost done");
				break;
			case 61:
				if(language==1)
					Think("Рисует Сукачев единицу-палку. Единица без носа, и подставочки под неё нет. Соединяет два конца, пронзает насквозь дисплей и рядом ставит идеальные два нуля.");
				else
					Think("Draws Sukachev a stick unit. A unit without a nose, and there is no coaster for it. Connects the two ends, pierces through the display and puts a perfect two zeros next to it.");
				break;
			case 62:
				Item(7);
				if(language==1)
					Think("27.11.1988. 13.20");
				else
					Think("11/27/1988. 13.20");
				break;
			case 63:
				if(language==1)
					Say("a","Красиво получилось.");
				else
					Say("a","Nicely done.");
				break;
			case 64:
				if(language==1)
					Say("a","Согласен, а?");
				else
					Say("a","I agree, huh?");
				break;
			case 65:
				if(language==1)
					Think("Андрей замирает, так и не нажав \"окей\".");
				else
					Think("Andrey freezes without clicking \"ok\".");
				break;
			case 66:
				if(language==1)
					Say("a","Андрей?");
				else
					Say("a","Andrey?");
				break;
			case 67:
				if(language==1)
					Think("Ищет взглядом всполох зелёных волос — когда Сукачев накурен, практически уверен в его существовании — но видит только выцветшие обои и драный коврик в прихожей.");
				else
					Think("Looks for a flash of green hair—when Sukachev is high, he's pretty sure it exists—but all he sees is faded wallpaper and a tattered rug in the hallway.");
				break;
			case 68:
				if(language==1)
					Think("Он один.");
				else
					Think("He's alone.");
				break;
			case 69:
				if(language==1)
					Say("a","Не прячься, красавица, я знаю что ты здесь. ");
				else
					Say("a","Don't hide, beauty, I know you're here. ");
				break;
			case 70:
				if(language==1)
					Think("Тишина.");
				else
					Think("Silence.");
				break;
			case 71:
				if(language==1)
					Think("Андрей смотрит себе под ноги — туда, где должен быть шприц. ");
				else
					Think("Andrey looks down at his feet to where the syringe should be. ");
				break;
			case 72:
				if(language==1)
					Say("a","Что, догнаться решил без спроса?");
				else
					Say("a","What, did you decide to catch up without asking?");
				break;
			case 73:
				if(language==1)
					Think("Шприца там нет.");
				else
					Think("The syringe is not there.");
				break;
			case 74:
				if(language==1)
					Say("a"," Какая непослушная тульпа!");
				else
					Say("a"," What a naughty tulpa!");
				break;
			case 75:
				PlaySound(2);
				if(language==1)
					Say("Наркоманка","Ты закрывала дверь?");
				else
					Say("Drug Addict","Did you close the door?");
				break;
			case 76:
				if(language==1)
					Think("“Какую дверь?” — угадывает Андрей, не расслышав ответ. Окончание было съедено, осталась одна буква — “у”.");
				else
					Think("“Which door?” Andrey guesses, not hearing the answer. The ending was eaten away, leaving only one letter — “y”.");
				break;
			case 77:
				if(language==1)
					Say("Наркоманка","Через которую, ты притащилась в мою квартиру!");
				else
					Say("Drug Addict","Through which you dragged yourself into my apartment!");
				break;
			case 78:
				if(language==1)
					Say("Наркоманка","Её закрывала?! ");
				else
					Say("Drug Addict","Did she shut her up?! ");
				break;
			case 79:
				if(language==1)
					Say("Наркоманка","Дура, оглохла? ");
				else
					Say("Junkie","Fool, deaf? ");
				break;
			case 80:
				if(language==1)
					Think("Она ещё десяток фраз адресует завалившейся набок подруге, прежде чем поймёт…");
				else
					Think("She says a dozen more phrases to her sideways friend before she realizes…");
				break;
			case 81:
				if(language==1)
					Think("Что подруга уже остыла.");
				else
					Think("That the girlfriend has already cooled down.");
				break;
			case 82:
				if(language==1)
					Think("Андрей исчезает, не успев оценить иронию. Исчезает злой, как черт, обвалив одним махом карниз и едва не размазав ту самую \"окей\".");
				else
					Think("Andrey disappears before he can appreciate the irony. Disappears angry as hell, collapsed in one fell swoop eaves and nearly smeared the very \"okay\".");
				break;
			case 83:
				if(language==1)
					Think("Оставив позади лишь никем не слышимый вой… ");
				else
					Think("Leaving behind only an inaudible howl... ");
				break;
			case 84:
				yield return new WaitForEndOfFrame();
				NextCoroutine("E1A1B1",3);
				break;
		}
		st.CoroutineEnding();
	}
}
