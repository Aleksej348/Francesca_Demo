using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Story01 : Story
{
	private IEnumerator C1A1()
	{
		st.CoroutineBegining();
		switch (st.step)
		{
			case 0:
				SetStats(new Dictionary<string, int> { { "Root", 1 } });
				SandInfoMessage(language==1?"Чувства к <color=#F0000E>Сане</color>": "Feelings for <color=#F0000E>Sanya</color>");
				if (language == 1) Think("Все мысли в голове лишь о нем.");
				else Think("All thoughts in my head are only about him.");
				yield return new WaitForEndOfFrame();
				break;
			case 1:
				if (language == 1) Think("Андрею и самому было бы смешно, если разочарование не ощущалось бы на языке пеплом от любимых сигарет.");
				else Think(" Andrey and himself would be funny if disappointment would not be felt on the tongue as ashes from your favorite cigarettes.");
				break;
			case 2:
				if (language == 1) Think("Слава богу, что эти мысли может заглушить собой потребность закурить косяк. И пусть болит давний шрам на языке от затушенного косяка, но…");
				else Think("Thank God those thoughts can drown out the urge to smoke a joint. And let the old scar on the tongue from the extinguished joint hurt, but ... ");
				break;
			case 3:
				if (language == 1) Think("Но вот мыслей разобраться с игрушкой, подумать о ней дважды — их нет, и Андрей как ни в чем не бывало возвращается домой.");
				else Think("But here are the thoughts to deal with the toy, to think about it twice - they are gone, and Andrey returns home as if nothing had happened.");
				break;
			case 4:
				if (language == 1) Say("a", "Как ни в чем не бывало");
				else Say("a", "As if nothing had happened");
				break;
			case 5:
				Thrill("a");
				PlaySound(3);
				if (language == 1) Say("a", "*Смех*");
				else Say("a", "*Laughter*");
				break;
			case 6:
				yield return new WaitForEndOfFrame();
				NextCoroutine("C1", 0, 23);
				break;
		}
		st.CoroutineEnding();
	}
	private IEnumerator C1A2()
	{
		st.CoroutineBegining();
		switch (st.step)
		{
			case -1:
				SetStats(new Dictionary<string, int> { { "Root", 2 } });
				SandInfoMessage(language==1?"Чувства к <color=#FD9A00>Жене</color>": "Feelings for <color=#FD9A00>Zhenya</color>");
				if (language == 1) Think("В мыслях остались лишь воспоминания о рыжих шелковистых волосах и об аромате ее мягких духов. Андрей сам того не заметил, как пустил слюну");
				else Think("All she thought of was her silky red hair and the scent of her soft perfume. Andrei himself did not notice how he salivated ");
				break;
			case 0:
				if (language == 1) Say("a", "Че там она говорила?");
				else Say("a", "What did she say?");
				break;
			case 1:
				if (language == 1) Say("a", "\"Отправлю тебе хенд мейд футболку, получи её, пожалуйста?\"");
				else Say("a", "\"I'll send you a handmade t-shirt, would you get it please?\"");
				break;
			case 2:
				Show("aa", "Право");
				StartDissolve("aa", 0);
				if (language == 1) Say("aa", "Причем отправила курьером. “Получи, распишись Андрюша! До почты-то ты сам не дойдешь, торчок сраный.”", true, false);
				else Say("aa", "Moreover, I sent it by courier. “Get it, sign Andryusha! You won't get to the post office yourself, you fucking junkie.”", true, false);
				break;
			case 3:
				if (language == 1) Say("aa", "Внимательная какая… Аж сердечко екает, да, Андрюш?");
				else Say("aa", "Attentive, what a... My heart skips a beat, yes, Andryusha?");
				break;
			case 4:
				if (language == 1) Say("a", "Ну началось…");
				else Say("a", "Well it's started…");
				break;
			case 5:
				if (language == 1) Say("aa", "А ты отправь ей в ответ курьером это чудо. Только букет не забудь.");
				else Say("aa", "And you send this miracle back to her by courier. Just don't forget the bouquet.");
				break;
			case 6:
				if (language == 1) Say("aa", "Какие цветы нынче означают \"там короче рядом с моей закладкой лежала какая то херня на жёлтом снегу, ну я и подобрал, дарю\"?", true, false);
				else Say("aa", "What flowers now mean \"there, in short, next to my bookmark there was some kind of garbage on yellow snow, well, I picked it up, I give it\"?", true, false);
				break;
			case 7:
				yield return new WaitForEndOfFrame();
				NextCoroutine("C1", 0, 23);
				break;
		}
		st.CoroutineEnding();
	}
	private IEnumerator C2A1()
	{
		st.CoroutineBegining();
		switch (st.step)
		{
			case 0:
				if (language == 1) Think("Андрей щурится в слишком ярком жёлтом свете и достает свой телефон. ");
				else Think("Andrey squints in the overly bright yellow light and pulls out his phone. ");
				yield return new WaitForSecondsRealtime(0.1f / speed);
				break;
			case 1:
				Move("aa", "Лево", "Право", 1f);
				EndDissolve("aa");
				if (language == 1) Think("Если эта игрушка умеет восстанавливать себя, то и попозировать для видеодоказательств сможет — дарить Сане какой-то левый мусор он не станет. ");
				else Think("If this toy can restore itself, then it will be able to pose for video evidence - it won't give Sana any rubbish. ");
				break;
			case 2:
				if (language == 1) Say("a", "Либо давай мне клёвый перфоманс, либо так и останешься валяться на снегу. Третьего не дано. ", true, false);
				else Say("a", "Either give me a cool performance, or just stay wallowing in the snow. There is no third.", true, false);
				break;
			case 3:
				if (language == 1) Think("Оказывается, держать камеру ровно и одновременно пытаться раздолбить плеер не так-то просто — камера как назло трясется, а игрушка никак не хочет ломаться. Появляется одна трещина, да и та похожа лишь на налипшую грязь.");
				else Think("It turns out that it's not so easy to keep the camera steady and at the same time try to gouge the player - the camera shakes, as luck would have it, and the toy does not want to break. One crack appears, and even that one looks like only dirt stuck to it.");
				break;
			case 4:
				if (language == 1) Think("На получившемся дерганом видео видно еще меньше, чем Андрею в реале — там и грязи-то никакой нет, разве что мелькает кусок парки. Так и не взглянув в сторону плеера, он  крепче сжимает в руках телефон — возится с удалением фото из галереи. ");
				else Think("On the resulting twitchy video, you can see even less than Andrey in real life - there is no dirt there, except for a piece of parka. Without looking in the direction of the player, he grips the phone tighter in his hands - fiddling with deleting photos from the gallery. ");
				break;
			case 5:
				Show("aa", "Право", new Vector3(1f, 1f, 0));
				StartDissolve("aa", 0);
				if (language == 1) Say("aa", "Доигрался, Андрюша…");
				else Say("aa", "Did it, Andryusha…");
				break;
			case 6:
				if (language == 1) Think("Сукачев секрет из того, что торчит, не делает — зачем? Внутри  — раздрай, его из крайности кидает в крайность, в истерики… ");
				else Think("Sukachev is the secret of what sticks out, doesn't do - why? Inside - tear, he is thrown from extreme to extreme, into hysterics ... ");
				break;
			case 7:
				if (language == 1) Think("Мир ему с каждым разом кажется все дальше и эфемернее. Он где-то там на фоне, искаженный веществами. Лишь время от времени приходится вспоминать, насколько уродлив и необратим, до смешного болезнен этот процесс употребления. ");
				else Think("The world seems to him more and more ephemeral each time. It's somewhere in the background, distorted by substances. Only from time to time one has to remember how ugly and irreversible, how ridiculously painful this process of use is. ");
				break;
			case 8:
				if (language == 1) Say("aa", "Как, например, сейчас?", true, false);
				else Say("aa", "How, for example, now?", true, false);
				break;
			case 9:
				Move("aa", "Право", "Лево", 1f);
				EndDissolve("aa");
				if (language == 1) Think("Сколько раз он разбивал кроссовком плеер и видел его обломки — это не может быть глюком! Что угодно может оказаться ложью, но не это! ");
				else Think("How many times has he smashed a player with a sneaker and seen its wreckage - this cannot be a glitch! Anything can be a lie, but not this! ");
				break;
			case 10:
				Show("aa", "Лево", new Vector3(-1f, 1f, 0));
				StartDissolve("aa", 1);
				if (language == 1) Say("aa", "Ой, доигрался…");
				else Say("aa", "Oh, I've finished my game…");
				break;
			case 11:
				Move("aa", "Лево", "Право", 1f);
				EndDissolve("aa");
				yield return new WaitForEndOfFrame();
				if (gm.Stats["Саня"] >= 1)
				{
					NextCoroutine("C2A1B1");
				}
				else
				{
					NextCoroutine("D1");
				}
				break;
		}
		st.CoroutineEnding();
	}
	private IEnumerator C2A1B1()
	{
		st.CoroutineBegining();
		switch (st.step)
		{
			case 0:
				PlaySound(0);
				SandInfoMessage(language==1?"Чувства к <color=#F0000E>Сане</color>": "Feelings for <color=#F0000E>Sanya</color>");
				if (language == 1) Think("Следом за \"доигрался\" Андрею приходит какой-то видеофайл.");
				else Think("After the \"finished game\" Andrey comes some video file.");
				yield return new WaitForSecondsRealtime(0.1f / speed);
				break;
			case 1:
				Dissolve("a", 1);
				if (language == 1) Say("a", "От Саши?..", true, false);
				else Say("a", "From Sasha?..", true, false);
				break;
			case 2:
				Thrill("a");
				if (language == 1) Think("Андрей пытается скрыть, что чуть не стонет от облегчения и блаженства — столько серотонина и в страшном сне не приснится ни одному антидепрессанту.");
				else Think("Andrey tries to hide the fact that he almost groans with relief and bliss - so much serotonin and in a terrible dream not a single antidepressant will dream.");
				break;
			case 3:
				if (language == 1) Think("Он даже сразу не открывает видео, боясь словить передоз. Где-то на заднем плане ликует наркозависимость — на игле ему снова комфортно.");
				else Think("He doesn't even open the video right away for fear of overdosing. Somewhere in the background, drug addiction rejoices - he is comfortable on the needle again.");
				break;
			case 4:
				if (language == 1) Think("Правда! Ей на радость, что он больше не чувствует желание заказать себе ещё чего-то — на сегодня вполне хватит пары косяков.");
				else Think("True! She's glad that he no longer feels the urge to order himself something else - a couple of joints will suffice for today.");
				break;
			case 5:
				if (language == 1) Think("Андрей, стараясь глубоко дышать, пытается сбить пульс болезненно стучащего под рёбрами сердца. По нервам разливается нега, едва не разжав судорожно вцепившиеся в телефон пальцы.");
				else Think("Andrey, trying to breathe deeply, tries to bring down the pulse of his painfully beating heart under the ribs. Bliss spreads through the nerves, almost unclenching the fingers convulsively clinging to the phone. ");
				break;
			case 6:
				Show("aa", "Право", new Vector3(1f, 1f, 0));
				StartDissolve("aa", 0);
				if (language == 1) Say("aa", "Смотри, айфон не урони от радости.");
				else Say("aa", "Look, don't drop your iPhone for joy.");
				break;
			case 7:
				if (language == 1) Think("На превью красуется смутно знакомая блондинка — ракурс не очень удачный, но Андрей уверен, что когда-то пересекался с ней после концерта. Откуда-то даже всплывает имя: Лера.");
				else Think("A vaguely familiar blonde flaunts on the preview - the angle is not very good, but Andrey is sure that he once crossed paths with her after the concert. From somewhere even the name pops up: Lera.");
				break;
			case 8:
				if (language == 1) Think("Когда включает, встречается с пьяными серыми глазами. Может, они и неплохо смотрятся, оттененные белыми локонами, но все-таки цвет должен быть глубже: на грани с существующей лишь в фэнтэзи чернотой. А волосы… Андрею всегда было на его волосы похуй.");
				else Think("When turned on, met with drunken gray eyes. Maybe they look good, tinted with white curls, but still the color should be deeper: on the verge of existing only in fantasy blackness. And the hair… Andrey never gave a fuck about his hair.");
				break;
			case 9:
				if (language == 1) Think("Девушка же наигранно, отчего ситуация становится даже забавнее, поднимает край чёрной футболки, произнеся игривое \"Снимаешь?\"");
				else Think("The girl playfully, which makes the situation even funnier, lifts the edge of her black T-shirt, saying playfully \"Are you filming?\"");
				break;
			case 10:
				if (language == 1) Think("Улыбается, обнажая зубы.  Делает вид, что понятия не имеет о камере, направленной прямо ей  в лицо. Отвечает закадровому голосу тихо, так что слышно  обрывки чужих разговоров с заднего плана.");
				else Think("Smiles, showing teeth. She pretends to have no idea about the camera pointed directly at her face. Responds to the voice-over quietly, so that you can hear snippets of other people's conversations from the background.");
				break;
			case 11:
				if (language == 1) Think("\"Какое сегодня число?\", односложный ответ откуда-то сбоку, потом довольное \"О, классно. Я, пожалуй, запишу!\". Записать, правда, не получается - очень невовремя подоспевает менеджер.");
				else Think("\"What's today's date?\", a monosyllabic answer from somewhere on the side, then a satisfied \"Oh, cool. I'll write it down!\". Recording, however, does not work - the manager arrives very untimely. ");
				break;
			case 12:
				Dissolve("a", 0);
				if (language == 1) Think("На этом короткое видео обрывается.");
				else Think("The short video ends here.");
				break;
			case 13:
				yield return new WaitForEndOfFrame();
				NextCoroutine("D1");
				break;
		}
		st.CoroutineEnding();
	}
	private IEnumerator C2A2()
	{
		st.CoroutineBegining();
		switch (st.step)
		{
			case 0:
				if (language == 1) Think("Андрей щурится в слишком ярком жёлтом свете и достает свой телефон.");
				else Think("Andrey squints in the overly bright yellow light and pulls out his phone.");
				break;
			case 1:
				if (language == 1) Think("Если эта херня умеет восстанавливать себя, то и попозировать для видеодоказательств сможет.");
				else Think("If this shit can repair itself, then it can pose for video evidence.");
				break;
			case 2:
				if (language == 1) Say("a", "И не дай бог это всего лишь приход, слышь?", true, false);
				else Say("a", "And God forbid this is just a parish, do you hear?", true, false);
				break;
			case 3:
				if (language == 1) Say("a", "Либо давай мне клёвый перфоманс, либо так и останешься валяться на снегу. Третьего не дано.");
				else Say("a", "Either give me a cool performance, or just stay wallowing in the snow. There is no third.");
				break;
			case 4:
				if (language == 1) Say("a", "А нет. Напиздел. Как всегда — напиздел.");
				else Say("a", "A no. Fucked up. As always - fucked up. ");
				break;
			case 5:
				if (language == 1) Say("a", "Третий вариант есть — я, ты, паяльник, эрогуро…");
				else Say("a", "There is a third option — me, you, soldering iron, eroguro…");
				break;
			case 6:
				if (language == 1) Say("aa", "Смекаешь?", true, false);
				else Say("aa", "Are you savvy?", true, false);
				break;
			case 7:
				if (language == 1) Think("Андрей удивлённо смотрит туда, где должна быть тульпа. Делает вид, что верит, что она там действительно есть, и притворяется, что смотрит прямо в глаза.");
				else Think("Andrey looks in surprise at where the tulpa should be. Pretends to believe she's really there and pretends to look straight in the eye.");
				break;
			case 8:
				PlaySound(4);
				if (language == 1) Say("a", "*ухмыляется*");
				else Say("a", "*grins*");
				break;
			case 9:
				if (language == 1) Say("aa", "Все для тебя, Андрюша. Разбирай паяльником игрушку на здоровье.");
				else Say("aa", "Everything for you, Andryusha. Dismantle the toy with a soldering iron to your health. ");
				Move("aa", "Лево", "Право", 2f);
				yield return new WaitForSecondsRealtime(2.2f / speed);
				Mirror("aa", new Vector3(-1f, 1f, 0), new Vector3(1f, 1f, 0));
				break;
			case 10:
				//Mirror("a",new Vector3(1f,1f,0),new Vector3(-1f,1f,0));
				if (language == 1) Say("aa", "Самое подходящие для тебя занятие…");
				else Say("aa", "The most suitable activity for you…");
				break;
			case 11:
				if (language == 1) Say("aa", "Представлять, что прижигаешь не пластмассу, а собственную кожу, и знать, что яиц не хватит даже на…", true, false);
				else Say("aa", "Imagine that you are not burning plastic, but your own skin, and knowing that there will not be enough eggs even for…", true, false);
				break;
			case 12:
				if (language == 1) Say("aa", "Как ты ей писал...");
				else Say("aa", "How did you write to her...");
				break;
			case 13:
				if (language == 1) Say("aa", "Селфхрам?");
				else Say("aa", "SelfTemple?");
				break;
			case 14:
				//Mirror("a",new Vector3(-1f,1f,0),new Vector3(1f,1f,0));
				if (language == 1) Think("Андрей виновато отводит взгляд.");
				else Think("Andrey looks away guiltily.");
				break;
			case 15:
				if (language == 1) Say("aa", "А у Жени хватает.");
				else Say("aa", "A Zhenya has enough.");
				Move("aa", "Право", "Лево", 2f);
				yield return new WaitForSecondsRealtime(2.2f / speed);
				Mirror("aa", new Vector3(1f, 1f, 0), new Vector3(-1f, 1f, 0));
				break;
			case 16:
				if (language == 1) Say("aa", "А ведь ты считаешь её жалкой… И я даже согласен: она и правда тупая, истеричная, чсвшная…", true, false);
				else Say("aa", "But you think she's pathetic... And I even agree: she's really stupid, hysterical, freaky...", true, false);
				break;
			case 17:
				PlaySound(4);
				if (language == 1) Say("aa", "*ухмыляется*");
				else Say("aa", "*grins*");
				break;
			case 18:
				if (language == 1) Say("aa", "Только вот кто тогда ты, если даже у неё больше, а, Андрюш? ");
				else Say("aa", "Only who are you then, even if she has more, eh, Andryush? ");
				break;
			case 19:
				PlaySound(3);
				if (language == 1) Say("aa", "*смеется*");
				else Say("aa", "*laughs*");
				break;
			case 20:
				if (language == 1) Say("a", "Больше, чем у тебя", true, false);
				else Say("a", "More than you", true, false);
				break;
			case 21:
				if (language == 1) Say("a", "Ведь тебя даже… ");
				else Say("a", "Because even you… ");
				break;
			case 22:
				if (language == 1) Say("a", "Нет? ");
				else Say("a", "No? ");
				break;
			case 23:
				PlaySound(4);
				Move("aa", "Лево", "Право", 1f);
				EndDissolve("aa");
				if (language == 1) Think("Андрею смешно.");
				else Think("Andrey is funny.");
				break;
			case 24:
				if (language == 1) Think("А ещё, оказывается, держать камеру ровно и одновременно пытаться раздолбить плеер не так-то просто — камера как назло трясется, а игрушка никак не хочет ломаться. Появляется одна трещина, да и та похожа лишь на налипшую грязь.");
				else Think("And yet, it turns out that holding the camera evenly and at the same time trying to gouge the player is not so easy - the camera shakes, as luck would have it, and the toy does not want to break. One crack appears, and even that one looks like only dirt stuck to it.");
				break;
			case 25:
				if (language == 1) Think("На получившемся дерганом видео видно еще меньше, чем Андрею в реале — там и грязи-то никакой нет, разве что мелькает кусок парки.");
				else Think("On the resulting twitchy video, you can see even less than Andrey in real life - there is no dirt there, except for a piece of parka.");
				break;
			case 26:
				if (language == 1) Think("Так и не взглянув в сторону плеера, он крепче сжимает в руках телефон — возится с удалением фото из галереи.");
				else Think("Without looking at the player, he tightens his grip on the phone as he fiddles with deleting the photo from the gallery.");
				break;
			case 27:
				Show("aa", "Право", new Vector3(1f, 1f, 0));
				StartDissolve("aa", 0);
				if (language == 1) Say("aa", "Доигрался, Андрюша…");
				else Say("aa", "Did it, Andryusha…");
				break;
			case 28:
				//Mirror("a",new Vector3(1f,1f,0),new Vector3(-1f,1f,0));
				if (language == 1) Think("Сукачев секрет из того, что торчит, не делает — зачем? Внутри — раздрай, его из крайности кидает в крайность, в истерики…");
				else Think("Sukachev is the secret of what sticks out, doesn't do - why? Inside - tear, he is thrown from extreme to extreme, into hysterics ... ");
				break;
			case 29:
				Move("aa", "Право", "Лево", 1f);
				EndDissolve("aa");
				if (language == 1) Think("Мир ему с каждым разом кажется все дальше и эфемернее. Он где-то там на фоне, искаженный веществами.");
				else Think("The world seems to him more and more ephemeral each time. It's somewhere in the background, distorted by substances.");
				break;
			case 30:
				if (language == 1) Think("Лишь время от времени приходится вспоминать, насколько уродлив и необратим, до смешного болезнен этот процесс употребления.");
				else Think("It's only from time to time that one has to remember how ugly and irreversible, how ridiculously painful this process of use is.");
				break;
			case 31:
				if (language == 1) Think("Сколько раз он разбивал кроссовком плеер и видел его обломки — это не может быть глюком! Что угодно может оказаться ложью, но не это! ");
				else Think("How many times has he smashed a player with a sneaker and seen its wreckage - this cannot be a glitch! Anything can be a lie, but not this! ");
				break;
			case 32:
				Show("aa", "Лево", new Vector3(-1f, 1f, 0));
				StartDissolve("aa", 1);
				if (language == 1) Say("aa", "Ой, доигрался…");
				else Say("aa", "Oh, I've finished my game…");
				break;
			case 33:
				Move("aa", "Лево", "Право", 1f);
				EndDissolve("aa");
				if (language == 1) Think("И как раз в этот момент камера ловит чёткий, до безумия яркий кадр — белый до рези в глазах снег и разбитая вдребезги игрушка. Она лежит, будто и правда позируя, заигрывая с ним, прежде чем снова собраться из частей и стать одним целым. ");
				else Think("And just at that moment the camera catches a clear, insanely bright frame - white snow in the eyes and a toy smashed to smithereens. She lies there like she's really posing, flirting with him before pulling herself back together and becoming one. ");
				break;
			case 34:
				if (language == 1) Think("Кислотно-зеленые капли оставляют после себя нетронутый иней на грязно-сером асфальте. Игрушка во всей своей красе лежит в центре настроенного фокуса. ");
				else Think("Acid green droplets leave untouched frost on dirty gray pavement. The toy in all its glory lies in the center of the adjusted focus. ");
				break;
			case 35:
				if (language == 1) Think("Андрей так не умеет. ");
				else Think("Andrey can't do that. ");
				break;
			case 36:
				if (language == 1) Think("Ни фокус настраивать, ни подбирать такие красивые фильтры. ");
				else Think("Neither focus to adjust, nor to select such beautiful filters. ");
				break;
			case 37:
				if (language == 1) Think("Его удел — сотни раз проигрывать записанные видео, игнорируя боль в закоченевших пальцах. ");
				else Think("His destiny is to play recorded videos hundreds of times, ignoring the pain in stiff fingers. ");
				break;
			case 38:
				PlaySound(4);
				if (language == 1) Say("a", "*смеется*");
				else Say("a", "*laughs*");
				break;
			case 39:
				if (language == 1) Think("И…");
				else Think("And…");
				break;
			case 40:
				yield return new WaitForEndOfFrame();
				NextCoroutine("D1");
				break;
		}
		st.CoroutineEnding();
	}
	private IEnumerator D1()
	{
		st.CoroutineBegining();
		switch (st.step)
		{
			case 0:
				Item(0);
				if (language == 1) Think("Берет игрушку в руки, крутит в свете фонаря. Даже не морщится брезгливо, как всегда, нет.");
				else Think("Takes the toy in his hands, turns it around in the light of the lantern. Doesn't even wince in disgust, as always, no.");
				yield return new WaitForSecondsRealtime(0.1f / speed);
				break;
			case 1:
				PlaySound(4);
				if (language == 1) Think("Пьяно ухмыльнувшись, сует ее в карман.");
				else Think("Drunkenly grinning, he puts it in his pocket.");
				break;
			case 2:
				if (language == 1) Think("Не к наркотикам — в другой.");
				else Think("Not to drugs - to another.");
				break;
			case 3:
				Fade(3f);
				yield return new WaitForSecondsRealtime(2f / speed);
				PlayMusic(4);
				Scene(0);
				EndDissolve("aa");
				EndDissolve("a");
				yield return new WaitForSecondsRealtime(2f / speed);
				Show("a", "Центр");
				StartDissolve("a", 0);
				if (language == 1) Think("До дома Андрей доходит часа за полтора, успев по пути купить бумажки для косяков и отморозив ноги в летних кедах, совсем не предназначенных для питерской погоды.");
				else Think("Andrey gets home in an hour and a half, having managed to buy papers for the joints on the way and frostbitten his feet in summer sneakers, not at all intended for St. Petersburg weather.");
				break;
			case 4:
				Show("aa", "Лево", new Vector3(-1f, 1f, 0));
				StartDissolve("aa", 0);
				if (language == 1) Say("aa", "Тоска, меланхоличные мысли и “Каста” через аудиозаписи вконтактике. Ничего нового...");
				else Say("aa", "Melancholy, melancholic thoughts and “Caste” through Vkontakte audio recordings. Nothing new...");
				break;
			case 5:
				if (language == 1) Think("Андрей греет ноги в душных синтетических тапках, подаренных той самой девочкой-томбойкой, влюбившейся в Андрюшу ещё тогда, когда он был не крашенным первокурсником с треками, записанными на коленке.");
				else Think("Andrey warms his feet in stuffy synthetic slippers, a gift from that same tomboy girl who fell in love with Andryusha back when he was an unpainted freshman with tracks recorded on his knee.");
				break;
			case 6:
				if (language == 1) Think("Когда он и сам выглядел пай мальчиком, носил чокер, подаренный девушкой, и с завидной регулярностью кидал ешки.");
				else Think("When he looked like a boy himself, wore a choker given to him by a girl, and threw eggs with enviable regularity.");
				break;
			case 7:
				EndDissolve("aa");
				Move("aa", "Лево", "Право", 1f);
				if (language == 1) Think("Детский плеер покоится совсем недалеко на столе, но Андрей отчего-то боится его трогать и занимает руки более взрослыми и интересными вещами: разворачивание закладки с травой, поиск остатков табака, упорное и долгое скручивание такого длинного и тонкого косяка, чтоб с первого же раза торкнуло.");
				else Think("The children's player rests not far away on the table, but Andrei is afraid to touch it for some reason and occupies his hands with more adult and interesting things: unfolding a bookmark with grass, searching for tobacco residues, persistent and long twisting of such a long and thin joint, so that from the first same time hit.");
				break;
			case 8:
				if (st.Path.Contains("C2") == true) { st.step = 9; goto case 9; }
				else { st.step = 12; goto case 12; }
			case 9:
				SandInfoMessage(language==1?"<color=#6AEC49>Франческа</color> довольна вами": "<color=#6AEC49>Francesca</color> is pleased with you");
				if (language == 1) Think("Не боится, скорее обижен за выеделенный чайной ложечкой мозг. Не на косяк же ему обижаться. Косяк Андрею ещё пригодится.");
				else Think(" Not afraid, rather offended by the teaspoon of the brain. Don't be offended by him. Andrey will still need the cant.");
				break;
			case 10:
				Dissolve("a", 1);
				if (language == 1) Say("a", "С ним портить отношения — не комильфо, в отличие от тебя!", true, false);
				else Say("a", "Spoiling relations with him is not comme il faut, unlike you!", true, false);
				break;
			case 11:
				if (language == 1) Think("Плеер, разумеется не отвечает");
				else Think("Player, of course not responding");
				break;
			case 12:
				Fade();
				yield return new WaitForSecondsRealtime(2f / speed);
				EndDissolve("a");
				SecondScene(0);
				yield return new WaitForSecondsRealtime(1f / speed);
				if (language == 1) Think("Бросает взгляд на личку. Зачитывает вслух, без интереса.");
				else Think("Glances at the PM. Reads aloud, without interest.");
				break;
			case 13:
				if (language == 1) Say("a", "“Залетай на стрим”, “го перепихнемся”, “приезжай в бар, бухнем”. Бла-бла-бла, идите нахуй.");
				else Say("a", "“Come on the stream”, “let's get laid”, “come to the bar, let's drink”. Blah blah blah, go fuck yourself.");
				break;
			case 14:
				Show("aa", "Право");
				StartDissolve("aa", 0);
				yield return new WaitForSecondsRealtime(0.5f / speed);
				if (language == 1) Say("aa", "Косяк куда интереснее.", true, false);
				else Say("aa", "The cant is much more interesting.", true, false);
				break;
			case 15:
				PlaySound(5);
				if (language == 1) Think("Ярким пламенем от зажигалки подкуривает, затягиваясь так глубоко, как может, но тут же кашляет с привычным ощущением слезящихся глаз.");
				else Think("He smokes with the bright flame from the lighter, inhaling as deeply as he can, but immediately coughs with the familiar sensation of watery eyes.");
				break;
			case 16:
				EndDissolve("aa");
				Move("aa", "Право", "Лево", 1f);
				if (language == 1) Think("Зато в голову густой и сладковатый на запах дым дает уже через несколько минут.");
				else Think("But in the head, thick and sweetish-smelling smoke gives in a few minutes.");
				break;
			case 17:
				PlaySound(6);
				if (language == 1) Think("Андрей бессовестно клеит неизвестную девочку из интереса, прекрасно понимая, что ей лет 17, и она обязательно скинет диалог с ним всем подружкам, мысленно поставит себя на новый статус в обществе таких же бестолковых фанаток и разгордится настолько, что едва ли не лопнет по причине «меня почти выебал Андрюша».");
				else Think("Andrey shamelessly glues an unknown girl out of interest, knowing full well that she is 17 years old, and she will definitely throw off the dialogue with him to all her girlfriends, mentally put herself on a new status in the society of the same stupid fans and become so proud that she almost bursts because of “Andryusha almost fucked me.”");
				break;
			case 18:
				if (language == 1) Think("Ещё один его друг в это же время записывает пару отвлеченных голосовых, предупреждает о нескором приезде обратно в Питер, а от Андрея в ответ получает гнетущую тишину, пока в личке с той малолеткой…");
				else Think("Another friend of his at the same time records a couple of distracted voices, warns of a delay in coming back to St. Petersburg, and receives oppressive silence from Andrey in response, while in a personal with that youngster ... ");
				break;
			case 19:
				Messenger(1, 0);
				PlaySound(0);
				if (language == 1) Say("АНДРЮША СУКАЧЕВ", "Милая, все бывает сказочно просто)");
				else Say("ANDRYUSHA SUKACHEV", "Darling, everything is fabulously simple)");
				break;
			case 20:
				Messenger(1, 1);
				PlaySound(0);
				if (language == 1) Say("АНДРЮША СУКАЧЕВ", "И звезды с твоего неба падают на землю.");
				else Say("ANDRYUSHA SUKACHEV", "And the stars from your sky are falling to the ground.");
				break;
			case 21:
				Messenger(1, 2);
				PlaySound(0);
				if (language == 1) Say("АНДРЮША СУКАЧЕВ", "Как насчет в бар?");
				else Say("ANDRYUSHA SUKACHEV", "How about a bar?");
				break;
			case 22:
				Show("aa", "Лево", new Vector3(-1f, 1f, 0));
				StartDissolve("aa", 0);
				yield return new WaitForSecondsRealtime(0.5f / speed);
				if (language == 1) Say("aa", "Ты же не собираешься бухать со школьницей?", true, false);
				else Say("aa", "You're not going to drink with a schoolgirl, are you?", true, false);
				break;
			case 23:
				if (gm.Stats["Root"] == 1)
				{
					SandInfoMessage(language==1?"Чувства к <color=#F0000E>Сане</color>": "Feelings for <color=#F0000E>Sanya</color>");
					if (language == 1) Think("Ему нужен продюсер, а не играть продюсера самому");
					else Think("He needs a producer instead of playing the producer himself");
				}
				else if (gm.Stats["Root"] == 2)
				{
					SandInfoMessage(language==1?"Чувства к <color=#FD9A00>Жене</color>": "Feelings for <color=#FD9A00>Zhenya</color>");
					if (language == 1) Think("Тем более, она даже не рыжая");
					else Think("Besides, she's not even a redhead");
				}
				else
				{
					if (language == 1) Say("a", "Нет конечно");
					else Say("a", "No of course");
				}
				break;
			case 24:
				SecondScene(0);
				EndDissolve("aa");
				Move("aa", "Лево", "Право", 1f);
				if (language == 1) Think("Докуривает косяк, бросает в пепельницу самый кончик, улавливая боковым зрением среди всех вкладок страницу Сани.");
				else Think("Finishes the joint, throws the very tip into the ashtray, out of the corner of his eye catching Sani's page among all the tabs.");
				break;
			case 25:
				if (language == 1) Think("Был в сети вчера в 13:09.");
				else Think("Was online yesterday at 13:09.");
				break;
			case 26:
				if (language == 1) Think("Выкручивает себе пальцы, портит суставы, корчится от ноющего указательного пальца. Синдром беспокойных рук. Таких беспокойных, что дотрагиваются, наконец, до загадочной игрушки. ");
				else Think("Twisting his fingers, ruining his joints, writhing at the aching index finger. Restless Hand Syndrome. So restless that they finally touch the mysterious toy. ");
				break;
			case 27:
				Item(0);
				if (language == 1) Think("Крутит ее между пальцев, сам того не замечая; сознание гасится косяком так мягко, как будто чьи-то бледные руки в татуировках нежно разбрасывают по голове ненужные мысли…");
				else Think("Twirls it between his fingers without noticing it; consciousness is extinguished in a joint so gently, as if someone's pale hands in tattoos gently scatter unnecessary thoughts over the head ... ");
				break;
			case 28:
				if (language == 1) Think("И вот уже буквы мешаются в вязкий кисель, слова уже не имеют веса и теряют сакральное значение, пока левая рука тянется к детской игрушке.");
				else Think("And now the letters are getting in the way of a viscous jelly, the words no longer have weight and lose their sacred meaning, while the left hand reaches for the children's toy.");
				break;
			case 29:
				if (language == 1) Say("a", "Лёгкая. Пластмассы пожалели…");
				else Say("a", "Easy. Plastics regretted…");
				break;
			case 30:
				if (language == 1) Think("Вместо экрана - картонка. Запах пали перебивает дым от косяка. Но синенькие кнопочки - прямо как у настоящего взрослого плеера.");
				else Think("Instead of a screen - a piece of cardboard. The smell of pali overwhelms the smoke from the joint. But little blue buttons - just like a real adult player. ");
				break;
			case 31:
				if (language == 1) Think("Палец соскальзывает на середину, и одна из синих кнопочек западает.");
				else Think("The finger slides down the middle and one of the blue buttons sinks.");
				break;
			case 32:
				if (language == 1) Think("Андрей вдыхает косяк поглубже и выдыхает дым прямо на игрушку. В тенях на картоне даже начинает что-то мерещиться.");
				else Think("Andrey inhales the joint deeply and exhales the smoke directly onto the toy. Something even begins to appear in the shadows on the cardboard. ");
				break;
			case 33:
				Item(1);
				break;
			case 34:
				if (language == 1) Think("Андрюша откидывается на кресло, блаженно закрывая глаза. Скалится прямо в экран ноутбука, на открытую на кой-то черт страничку Сани. ");
				else Think("Andryusha leans back in his chair, closing his eyes blissfully. He grins right at the laptop screen, at Sanya's open page for some damn thing. ");
				break;
			case 35:
				if (language == 1) Say("a", "Зачем ты на неё зашёл, зачем тебе смотреть, сколько у него подписчиков, зачем думать, не запустить ли кликбейтный стрим на твиче и слушать на нем портфолио Сани…");
				else Say("a", "Why did you go to her, why do you need to look at how many subscribers he has, why think about starting a clickbait stream on twitch and listening to Sanya's portfolio on it…");
				break;
			case 36:
				if (language == 1) Think("Зачем, зачем, зачем…");
				else Think("Why, why, why…");
				break;
			case 37:
				if (language == 1) Think("Пара секунд проходит спокойно, пока Андрея не окатывает омерзение. От густого дыма в лёгких он морщится, сжимая плеер сильнее.");
				else Think("A couple of seconds pass quietly until Andrey is overcome with disgust. The thick smoke in his lungs makes him wince, squeezing the player tighter.");
				break;
			case 38:
				if (language == 1) Think("Зачем? Что это за чувство? Может быть это зависть?");
				else Think("Why? What is this feeling? Maybe it's jealousy?");
				break;
			case 39:
				if(language==1)
                ChoiceList(
				new string[] { "Спросить об этом у Андрюши", "Спросить у себя", "Ответить, что это любовь" },
				new int[] { 2, 2, 2 },
				new string[] { "D1A1", "D1A2", "D1A3" },
				new int[] { 0, 0, 0 },
				new bool[] { st.Path.Contains("C2") == true, true, gm.Stats["Саня"] >= 1 && gm.Stats["Root"] != 2 },
				new string[]{"<color=#FF00D1>Безумие</color>+1,\r\n<color=#32E9AB>Эскапизм</color>+1,\r\n<color=#6AEC49>Франческа</color>+1\r\nТребуется:\r\nВыбор: \"Не трогать\"",
			"Если <color=#A8FFFC>Искренность</color><=0,\r\nто <color=#FF00D1>Безумие</color>+1\r\n   ",
			"<color=#F0000E>Саня</color>+1\r\nТребуется:\r\n<color=#F0000E>Саня</color>>=1, Рут!=<color=#FD9A00>Женя</color>"});
				else
				ChoiceList(
				new string[] { "Ask Andryusha about it", "Ask yourself", "Answer that this is love" },
				new int[] { 2, 2, 2 },
				new string[] { "D1A1", "D1A2", "D1A3" },
				new int[] { 0, 0, 0 },
				new bool[] { st.Path.Contains("C2") == true, true, gm.Stats["Саня"] >= 1 && gm.Stats["Root"] != 2 },
				new string[]{"<color=#FF00D1>Madness</color>+1,\r\n<color=#32E9AB>Escapism</color>+1,\r\n<color=#6AEC49>Francesca</color>+1\r\nRequires:\r\nSelection: \"Do not touch\"",
				"If <color=#A8FFFC>Sincerity</color><=0,\r\nthen <color=#FF00D1>Madness</color>+1\r\n ",
				"<color=#F0000E>Sanya</color>+1\r\nRequired:\r\n<color=#F0000E>Sanya</color>>=1, Root!=<color=#FD9A00>Zhenya</color>"});
				break;
		}
		st.CoroutineEnding();
	}
}
