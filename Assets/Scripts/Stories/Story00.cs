using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Story00 : Story
{
	//ChoiceList([^;]*\r\n)*.*
	//$&                else\r\n                $&
	private IEnumerator A1()
	{
		st.CoroutineBegining();
		switch (st.step)
		{
			case 0:				
				PlayMusic(0);
				yield return new WaitForEndOfFrame();
				st.NextStep();
				break;
			case 1:
				StartDissolve("a",0);
				st.SetMaterial(0, new Dictionary<string, float> { { "_WaveSpeed", 2.5f }, { "_WaveAmplitude", 0.003f } });
				if (language == 1) Think("Больше ему, конечно,подходило именно “Андрюша” — этакий вечно молодой и вечно пьяный, как завещал сам малыш Пимп.");
				else Think("Of course, it was Andryusha that suited him better - a sort of forever young and forever drunk, as little Pimp himself bequeathed.");
				break;
			case 2:				
				if (language == 1) Think("Андрюше по заветам нужно было начать уже свое священное писание. Он и пытался - правда получалось не очень.");
				else Think("According to the precepts, Andryusha had to start his scripture already. He tried - though it didn't work out very well.");
				break;
			case 3:
				Dissolve("a", 1);
				if (language == 1) Say("a", "Я не торчок, но...");
				else Say("a", "I'm not a junkie, but...");
				break;
			case 4:
				Dissolve("a", 0);
				if (language == 1) Think("Цветные прядки волос, образ с сигаретой на фотке в инстаграме — ну натурально тот чудак на букву «М» из песен знакомой Алёны.");
				else Think("Colored strands of hair, an image with a cigarette in a photo on Instagram - well, of course, that eccentric with the letter \"M\" from the songs of my friend Alena.");
				break;
			case 5:
				if (language == 1) Think("Прямо из \"14\" — старше неё, конечно, но выглядящий достаточно по-мальчишески и «андрогинно».");
				else Think("Straight out of \"14\" - older than her, of course, but looking quite boyish and \"androgynous.\"");
				break;
			case 6:
				if (language == 1) Say("a", "Двадцать три — как пьяные восемнадцать.");
				else Say("a", "Twenty-three is like drunken eighteen.");
				break;
			case 7:				
				if (language == 1) Think("Пальцы не слушаются. Уже битый час не может написать твит или хоть какое-нибудь сообщение, чтобы порадовать фанатов из самых дальних уголков необъятной.");
				else Think("Fingers won't work. It's been an hour since I've been able to write a tweet or even a message to please fans from the farthest corners of the vast.");
				break;
			case 8:
				EndDissolve("a");
				yield return new WaitForSeconds(0.7f);
				StartDissolve("aa", 0);
				if (language == 1) Say("aa", "Что такое? У обиженного Андрея ни циферки, ни буковки теперь не сходятся? ");
				else Say("aa", "What is it? The offended Andrey has neither numbers nor letters that match now?");
				break;
			case 9:
				EndDissolve("aa");
				yield return new WaitForSeconds(0.7f);
				StartDissolve("a", 0);
				if (language == 1) Say("a", "Прекрати.");
				else Say("a", "Stop.");
				break;
			case 10:
				if (language == 1) Think("Оброс ещё сильнее. Аквамариновая челка вымывается, а сквозь нее проступает желтизна обесцвеченного хакера с пока еще зеленоватой дымкой.");
				else Think("Fluffier even more. Aquamarine bangs are washed out, revealing bleached hacker yellow with a still greenish haze.");
				break;
			case 11:
				EndDissolve("a");
				yield return new WaitForSeconds(0.7f);
				StartDissolve("aa", 0);
				if (language == 1) Say("aa", "На кой ты пепельницу на самый угол стола поставил? Перевернется — дыру ведь в линолеуме  прожжешь.");
				else Say("aa", "Why did you put an ashtray on the very corner of the table? It will turn over - you will burn a hole in the linoleum.");
				break;
			case 12:
				EndDissolve("aa");
				yield return new WaitForSeconds(0.7f);
				StartDissolve("a", 0);
				if (language == 1) Say("a", "Похуй.");
				else Say("a", "Fuck you.");
				break;
			case 13:
				if (language == 1) Think("Он сидит за компом, опираясь на локоть. Прячется от самого же себя в отражении окна за белыми полупрозрачными занавесками.");
				else Think("He is sitting at the computer, leaning on his elbow. Hiding from himself in the reflection of the window behind white translucent curtains.");
				break;
			case 14:
				if (language == 1) Think("Тяжелые мысли.");
				else Think("Heavy thoughts.");
				break;
			case 15:
				EndDissolve("a");
				yield return new WaitForSeconds(0.7f);
				StartDissolve("aa", 0);
				if (language == 1) Say("aa", "Помнишь, как человечек, которым ты так сильно дорожишь, наконец сказал то, что было у всех на уме последний год?");
				else Say("aa", "Remember how the little man you hold so dear finally said what was on everyone's mind last year?");
				break;
			case 16:
				Dissolve("aa", 1);
				if (language == 1) Say("aa", "Про весь пьяный угар на концертах? Про истерики и слезы с соплями, которые так красиво вписываются в грустные песенки?");
				else Say("aa", "About all the drunken frenzy at concerts? About tantrums and tears with snot that fit so beautifully into sad songs?");
				break;
			case 17:
				Fade(2f, language == 1 ? "«Андрюша, ты клоун. Самый настоящий»" : "Andryusha, you are a clown. The real one");
				yield return new WaitForSeconds(2f);
				EndDissolve("aa");
				yield return new WaitForSeconds(0.7f);
				StartDissolve("a", 0);
				yield return new WaitForEndOfFrame();
				st.NextStep();
				break;
			case 18:
				if (language == 1) Think("Будь это просто посыл нахуй — Андрей не обиделся бы совсем. Также как и на попытки обсмеять фиты с другими бесталанными, но смазливыми кумирами малолеток.");
				else Think("If it was just a fucking message, Andrey would not be offended at all. As well as attempts to ridicule feats with other untalented, but cute teen idols.");
				break;
			case 19:
				if (language == 1) Think("И на все баллады про трушность махнул бы рукой — даже в самые худшие дни Андрюшина самооценка капает слюной на всех критиков его творчества.");
				else Think("And I would give up on all the ballads about ugliness - even in Andryushin's worst days, self-esteem drips with saliva on all critics of his work.");
				break;
			case 20:
				if (language == 1) Think("*Особая тема в десять раз переписанном сборнике стихов для “пост-рэпового” периода.");
				else Think("*Special theme in a tenfold rewritten collection of poems for the \"post-rap\" period.");
				break;
			case 21:
				if (language == 1) Think("Но...");
				else Think("But...");
				break;
			case 22:
				EndDissolve("a");
				yield return new WaitForSeconds(0.7f);
				StartDissolve("aa", 0);
				if (language == 1) Say("aa", "«Андрюша, ты клоун. Самый настоящий». Помнишь?");
				else Say("aa", "\"Andryusha, you are a clown. The real one.\" Do you remember?");
				break;
			case 23:
				if (language == 1)
					ChoiceList(
					new string[] { "Вспомнить", "Перестать играть шизика" },
					new int[] { 0, 0 },
					new string[] { "A2", "A1" },
					new int[] { 0, 24 },
					new bool[] { true, true },
					new string[] { "<color=#A8FFFC>Искренность</color>+1,\r\n<color=#F0000E>Саня</color>+1 позже", "<color=#FF00D1>Безумие</color>-1" });
				else
					ChoiceList(
					new string[] { "Remember", "Stop playing crazy" },
					new int[] { 0, 0 },
					new string[] { "A2", "A1" },
					new int[] { 0, 24 },
					new bool[] { true, true },
					new string[] { "<color=#A8FFFC>Sincerity</color>+1,\r\n<color=#F0000E>Sanya</color>+1 later", "<color=#FF00D1>Madness</color>-1" });
				break;
			case 24:
				SetStats(new Dictionary<string, int> { { "Безумие", -1 } });
				EndDissolve("aa");
				yield return new WaitForSeconds(0.7f);
				StartDissolve("a", 0);
				if (language == 1) Say("a", "На сегодня хватит самокопания. Там кто-то в личку написал, лучше проверить. Мож чо важное.");
				else Say("a", "That's enough self-digging for today. Someone wrote there in a personal message, it's better to check it. It might be important.");
				break;
			case 25:
				Fade(2f);
				yield return new WaitForSeconds(2f);
				EndDissolve("a");
				yield return new WaitForEndOfFrame();
				NextCoroutine("B1");
				break;
		}
		st.CoroutineEnding();
	}
	private IEnumerator A2()
	{
		st.CoroutineBegining();
		switch (st.step)
		{
			case 0:
				Fade();
				yield return new WaitForSeconds(2f);
				Scene(1);
				PlayMusic(1);
				StartDissolve("aa", 0);
				yield return new WaitForSeconds(1f);
				if (language == 1) Say("aa", "Свет софитов какой-то паршивый, в клубе воняет мочой.");
				else Say("aa", "Spotlights are kind of lousy, the club stinks of urine.");
				break;
			case 1:
				if (language == 1) Say("aa", "Темнота, и ужасная, ужасная ломаная-переломанная светомузыка — диско шар светит прямо в твои красные от дури глаза…");
				else Say("aa", "Darkness, and terrible, terrible broken-broken light music - the disco ball shines right into your dope-red eyes...");
				break;
			case 2:
				if (language == 1) Say("aa", "Да, светит! И плевать, что он остался за дверью гримерки, и всё это лишь твоя жалкая попытка бороться с разочарованием…", true);
				else Say("aa", "Yes, it's shining! I don't care that he was left behind the dressing room door, and all this is just your pathetic attempt to deal with disappointment...", true);
				break;
			case 3:
				if (language == 1) Say("aa", "Точно такая же, как и этот выдуманный диалог с выдуманным мной… Но мы не отвлекаемся от ностальгического трипа!");
				else Say("aa", "Exactly the same as this fictitious dialogue with my fictitious one... But we are not distracted from the nostalgic trip!");
				break;
			case 4:
				if (language == 1) Say("aa", "Твой лучший друг сидит рядом и угарает над тобой. Ну и что? Он же просто продолжает твою же шутку! Просто стоит рядышком, держит в руках стаканчик пива и усмехается…");
				else Say("aa", "Your best friend sits next to you and swears at you. So what? He just continues your own joke! Just stands next to him, holds a glass of beer in his hands and grins...");
				break;
			case 5:
				if (language == 1) Say("aa", "Он сюда пришёл, чтобы оторваться после первой рабочей недели. Или что-то отпраздновать —  ты в душе не ебешь, что, но что-то пиздецки важное. ");
				else Say("aa", "He came here to party after his first week of work. Or to celebrate something - you don't give a fuck what, but something fucking important.");
				break;
			case 6:
				if (language == 1) Say("aa", "Ему приходится делать вид, что твои шутки — действительно всего лишь шутки.");
				else Say("aa", "He has to pretend that your jokes are really just jokes.");
				break;
			case 7:
				if (language == 1) Say("aa", "И что они смешные.", true);
				else Say("aa", "And they're funny.", true);
				break;
			case 8:
				Dissolve("aa", 1);
				PlaySound(14);
				if (language == 1) Say("aa", "*смех*");
				else Say("aa", "*laughter*");
				break;
			case 9:
				if (language == 1) Say("aa", "Но помимо Феди есть ещё и ты. И ты не спал двое суток, чтобы достать вам проходку.");
				else Say("aa", "But besides Fedya, there is also you. And you didn't sleep for two days to get you a tunnel.");
				break;
			case 10:
				if (language == 1) Say("aa", "А сейчас полулежишь на диване смотришь на Саню, сидящего сбоку от своей звездной группы — раздавшейся, с миниатюрными жёнами —  трезвого, скучного…");
				else Say("aa", "And now you're reclining on the couch, looking at Sanya, sitting on the side of his star group - blown out, with petite wives - sober, boring...");
				break;
			case 11:
				Dissolve("aa", 0);
				if (language == 1) Say("aa", "И блядь такую фразу слышишь от твоего дружка. ");
				else Say("aa", "That's the fucking phrase you hear from your friend.");
				break;
			case 12:
				Move("aa", "Центр", "Право", 0.5f);
				Show("f", "Лево");
				StartDissolve("f", 0);
				if (language == 1) Say("f", "Ну, я не согласен. Индустрия, конечно, на спаде, но а когда так не было?");
				else Say("f", "Well, I don't agree. The industry is in decline, of course, but when wasn't it?");
				break;
			case 13:
				if (language == 1) Say("aa", "Интересное началось, ага?", true);
				else Say("aa", "Interesting has begun, huh?", true);
				break;
			case 14:
				EndDissolve("aa");
				yield return new WaitForSeconds(0.5f);
				Show("a", "Право");
				StartDissolve("a", 0);
				if (language == 1) Say("a", "Никогда. Никогда не было, Федя. Мне ебаться на сцене не разрешают. ");
				else Say("a", "Never. Never, Fedya. I'm not allowed to fuck on stage.");
				break;
			case 15:
				if (language == 1) Say("a", "Потребляди!", true);
				else Say("a", "Consume!", true);
				break;
			case 16:
				if (language == 1) Say("a", "Слушать мои песенки про ультранасилие их устраивает, а вот когда я хочу поебаться на сцене —... ");
				else Say("a", "Listening to my songs about ultra-violence suits them, but when I want to fuck on stage -...");
				break;
			case 17:
				Show("aa", "Центр");
				Move("aa", "Центр", "Центр", 0.5f, new Vector2(0, -8f), new Vector2(0, 0));
				StartDissolve("aa", 0);
				if (language == 1) Say("aa", "Ты так не вовремя отлип тогда от телефона, Андрюш.");
				else Say("aa", "You left your phone at the wrong time, Andryush.");
				break;
			case 18:
				if (language == 1) Say("aa", "Хотел просто выйти покурить и вернуться счастливым, но тебе помешали твои огроменные яйца. ");
				else Say("aa", "I just wanted to go out for a smoke and come back happy, but your huge balls got in the way.");
				break;
			case 19:
				if (language == 1) Say("aa", "Так тебе тогда казалось?");
				else Say("aa", "So it seemed to you then?");
				break;
			case 20:
				Dissolve("aa", 1);
				PlaySound(20);
				if (language == 1) Say("aa", "Я отсюда чувствую твой стыд.");
				else Say("aa", "I feel your shame from here.");
				break;
			case 21:
				LongShaker(2f, 2f);
				PlaySound(22);
				Item(10);
				PlayMusic(10);
				if (language == 1) Say("a", "А мне не стыдно.");
				else Say("a", "I'm not ashamed.");
				break;
			case 22:
				Item(11);
				EndDissolve("aa");
				if (language == 1) Think("От его слов иллюзия пошатнулась. По краям стала неточной, и силуэты людей поблёкли.");
				else Think("At his words, the illusion was shaken. The edges became inaccurate, and the silhouettes of people faded.");
				break;
			case 23:
				Dissolve("a", 1);
				if (language == 1) Think("Андрей улыбается. Только не для Андрюши. И не для этих копий. ");
				else Think("Andrey smiles. Not for Andryusha. And not for these copies. ");
				break;
			case 24:
				if (language == 1) Think("В Иллюзии все идёт своим чередом: блеклый Федя отпивает пиво, но прежде чокается с коктейлем Тани. Она протянулась  к нему через стол, едва не разлив голубую лагуну на закуски.");
				else Think("In the Illusion, everything goes on as usual: faded Fedya sips beer, but first clinks glasses with Tanya's cocktail. She reached out across the table to him, almost spilling the blue lagoon on snacks.");
				break;
			case 25:
				Fade();
				yield return new WaitForSeconds(2f);
				st.SetMaterial(0, new Dictionary<string, float> { { "_WaveSpeed", 4f }, { "_WaveAmplitude", 0.02f } });
				CloseItem(10); CloseItem(11);
				PlayMusic(1, 0.8f);
				Dissolve("a", 0);
				if (language == 1) Say("f", "А потом эти потребляди говорят, что ты клоун. ");
				else Say("f", "And then those consumers say you're a clown.");
				break;
			case 26:
				PlaySound(13);
				if (language == 1) Think("Таня как всегда смеётся с любой несмешной шутки, даже если это и не шутка вовсе — в её наушниках всегда смешно.");
				else Think("Tanya, as always, laughs at any unfunny joke, even if it's not a joke at all - it's always funny in her headphones.");
				break;
			case 27:
				if (language == 1) Think("А блёклый Андрей не медлит с ответом.");
				else Think("And faded Andrey does not hesitate to answer.");
				break;
			case 28:
				Dissolve("a", 1);
				if (language == 1) Say("a", "А я и есть клоун,\"\" самый настоящий!", true);
				else Say("a", "And I am a real clown!", true);
				break;
			case 29:
				if (language == 1) Think("На лице Феди отражается его плохо — но с большим усилием — скрываемое беспокойство. Короткая неловкость убивается сразу же. Саней.");
				else Think("Fedya's face reflects poorly - but with great effort - hidden anxiety. A short awkwardness is killed immediately. Sanya.");
				break;
			case 30:
				EndDissolve("f");
				yield return new WaitForSeconds(0.5f);
				Show("s", "Лево");
				StartDissolve("s", 0);
				Dissolve("a", 0);
				if (language == 1) Say("s", "Какие хорошие слова… Напишу их тебе на футболке. ");
				else Say("s", "What nice words... I'll write them on your T-shirt.");
				break;
			case 31:
				if (language == 1) Say("s", "Только нелегко придётся — клоунов сейчас много. Чтобы доказать, что ты среди них самый пиздатый, какое-то время придётся притворяться, что ты — несмешной.", true);
				else Say("s", "It's just not going to be easy - there are a lot of clowns now. To prove that you are the most fucked up among them, you will have to pretend for a while that you are not funny.", true);
				break;
			case 32:
				Show("aa", "Центр");
				StartDissolve("aa", 0);
				if (language == 1) Say("aa", "Да, да.");
				else Say("aa", "Yes, yes.");
				break;
			case 33:
				if (language == 1) Think("Андрюша пренебрежительно машет рукой.");
				else Think("Andryusha waves his hand disdainfully.");
				break;
			case 34:
				if (language == 1) Say("aa", "Вот уж у кого действительно нет ни стыда ни совести.", true);
				else Say("aa", "Who really has no shame or conscience.", true);
				break;
			case 35:
				//Move("a","Право","Центр",1f);
				//Move("aa","Центр","Право",1f);
				if (language == 1) Think("Он подходит к Сане, все ещё яркому в этом монохромном мире.");
				else Think("He approaches Sana, still bright in this monochrome world.");
				break;
			case 36:
				if (language == 1) Think("Саша смотрит на Андрея со своего места на другом конце стола. ");
				else Think("Sasha looks at Andrey from his seat at the other end of the table. ");
				break;
			case 37:
				if (language == 1) Think("Внаглую пялится, не отрываясь — ни когда тянется в карман за пачкой сигарет, ни когда девушка рядом с ним притворно смеётся, ещё до того, как он у неё спрашивает:");
				else Think("He stares insolently, not looking away - neither when he reaches into his pocket for a pack of cigarettes, nor when the girl next to him fake laughs, even before he asks her:");
				break;
			case 38:
				if (language == 1) Say("s", "О черт, я же не могу так говорить? Эй, Таня, я же могу такое говорить?");
				else Say("s", "Oh shit, I can't say that? Hey Tanya, can I say that?");
				break;
			case 39:
				if (language == 1) Say("aa", "А Таня между прочим твоя девушка. Или уже нет?", true);
				else Say("aa", "By the way, Tanya is your girlfriend. Is she already gone?", true);
				break;
			case 40:
				if (language == 1) Say("aa", "Ты так быстро меняешь шалав, что я не поспеваю.");
				else Say("aa", "You're changing whores so fast I can't keep up.");
				break;
			case 41:
				if (language == 1) Say("aa", "Чё она там ляпнула? ");
				else Say("aa", "What did she blurt out there?");
				break;
			case 42:
				EndDissolve("aa");
				yield return new WaitForSeconds(0.5f);
				Show("t", "Центр");
				StartDissolve("t", 0);
				if (language == 1) Say("t", "Я тебе не мамочка.");
				else Say("t", "I'm not your mommy.");
				break;
			case 43:
				Dissolve("a", 1);
				if (language == 1) Think("В воспоминании Сукачев кажется таким живым в сравнении с настоящим. Там он растягивает губы в улыбке от каждого взгляда своего кумира.");
				else Think("In the memory, Sukachev seems so alive compared to the present. There he stretches his lips in a smile at every glance of his idol.");
				break;
			case 44:
				if (language == 1) Say("a", " Можешь. И я не пиздюк, глаза-то разуй и обращайся прямо ко… Блядь! Забыл, че хотел сказать.", true);
				else Say("a", " You can. And I'm not a cunt, open your eyes and address directly to ... Fuck! I forgot what I wanted to say.", true);
				break;
			case 45:
				if (language == 1) Say("a", "Ебли на сцене не предвидится, только аскорбинки. У вас не найдётся?");
				else Say("a", "Fucking on stage is not expected, only ascorbs. Do you have any?");
				break;
			case 46:
				if (language == 1) Say("s", "Ну, у меня одна есть. Одолжить? Эй, подвиньтесь, дайте мне ему руку помощи протянуть!");
				else Say("s", "Well, I have one. Can I borrow it? Hey, move over, give me a helping hand!");
				break;
			case 47:
				if (language == 1) Say("t", "Осторожнее!!!", true);
				else Say("t", "Careful!!!", true);
				break;
			case 48:
				if (language == 1) Say("t", "Андрей! Только не соглашайся, если он предложит стать твоим продюсером…");
				else Say("t", "Andrey! Just don't agree if he offers to become your producer...");
				break;
			case 49:
				EndDissolve("t");
				if (language == 1) Think("Сказав это, она привстаёт и вжимается в стену, пропуская Саню вперёд. Каблук новых босоножек такой тонкий, что вот-вот сломается и заставит Таню разлить на и без того липкий пол свой люминесцентный коктейль.");
				else Think("Having said this, she stands up and presses against the wall, letting Sanya go forward. The heel of the new sandals is so thin that it is about to break and make Tanya spill her luminescent cocktail on the already sticky floor.");
				break;
			case 50:
				if (language == 1) Say("a", "Да я сам возьму.", true);
				else Say("a", "Yes, I'll take it myself.", true);
				break;
			case 51:
				EndDissolve("s");
				yield return new WaitForSeconds(0.5f);
				Show("f", "Лево");
				StartDissolve("f", 0);
				if (language == 1) Say("f", "Эй, Андрей. Андрей! Все, хватит. Серьёзно, успокойся! ");
				else Say("f", "Hey Andrey. Andrey! That's enough. Seriously, calm down!");
				break;
			case 52:
				if (language == 1) Think("Но Андрей слышит только Санино:");
				else Think("But Andrey only hears Sanino:");
				break;
			case 53:
				EndDissolve("f");
				yield return new WaitForSeconds(0.5f);
				Show("s", "Лево");
				StartDissolve("s", 0);
				if (language == 1) Say("s", "Только я не гарантирую, что это не плацебо.");
				else Say("s", "Only I can't guarantee it's not a placebo.");
				break;
			case 54:
				EndDissolve("a");
				EndDissolve("s");
				yield return new WaitForSeconds(0.5f);
				StartDissolve("aa", 0);
				if (language == 1) Say("aa", "Ну, как тебе эта пытка?");
				else Say("aa", "Well, how do you like this torture?");
				break;
			case 55:
				if (language == 1)
					ChoiceList(
					new string[] { "Нравится", "Отвратительно" },
					new int[] { 0, 0 },
					new string[] { "A2", "A2" },
					new int[] { 56, 71 },
					new bool[] { true, true },
					new string[] { "<color=#A8FFFC>Искренность</color>+1,\r\n<color=#F0000E>Саня</color>+1", "<color=#FF00D1>Безумие</color>-1" });
				else
					ChoiceList(
					new string[] { "Like", "Disgusting" },
					new int[] { 0, 0 },
					new string[] { "A2", "A2" },
					new int[] { 56, 71 },
					new bool[] { true, true },
					new string[] { "<color=#A8FFFC>Sincerity</color>+1,\r\n<color=#F0000E>Sanya</color>+1", "<color=#FF00D1>Madness</color >-1" });
				break;
			case 56:
				SetStats(new Dictionary<string, int> { { "Искренность", +1 }, { "Саня", +1 } });
				if (language == 1) Say("aa", "Рад прокрутить ещё немного этого наркоманского диафильма для старого друга.");
				else Say("aa", "Glad to run some more of that junkie filmstrip for an old friend.");
				break;
			case 57:
				EndDissolve("aa");
				PlaySound(13);
				if (language == 1) Think("Раздаётся неловкий смех. Таня садится назад, Саня проходит, успев дважды коснуться бедром её колен и не обратив на это никакого внимания — он ведь так увлечен беседой об искусстве, которую больше никто не ведёт, и своей сигаретой. ");
				else Think("Awkward laughter is heard. Tanya sits back, Sanya passes, having managed to touch her knees twice with his thigh and not paying any attention to it - he is so engrossed in a conversation about art that no one else is having, and his cigarette. ");
				break;
			case 58:
				if (language == 1) Think("Андрей подхватывает Федино пиво и встаёт со своего места. Ошалелым взглядом скользит по чужим лицам — а Саниного уже нигде нет. ");
				else Think("Andrey grabs Fedino's beer and gets up from his seat. With a stunned look, he glides over other people's faces - and Sanya is nowhere to be found.");
				break;
			case 59:
				if (language == 1) Think("Есть Таня, прибавляющая громкость в единственном наушнике. Есть Федя. Есть ещё с десяток кого-то там — для Андрея всё это копии знакомых с тусовки, друг от друга не отличимые. Так, паштет из серой массы. ");
				else Think("There is Tanya, turning up the volume in a single earpiece. There is Fedya. There are about a dozen others there - for Andrey, all these are copies of acquaintances from the party, indistinguishable from each other. So, a pate of gray mass.");
				break;
			case 60:
				if (language == 1) Think("На секунду он почти поверил…");
				else Think("For a second, he almost believed...");
				break;
			case 61:
				if (language == 1) Think("Но, конечно же, Саня тут. Затягивается и практически не выдыхает дым.");
				else Think("But, of course, Sanya is here. He inhales and practically does not exhale smoke.");
				break;
			case 62:
				Show("a", "Право");
				StartDissolve("a", 0);
				if (language == 1) Say("a", "Не-не-не, без рук! А то закенселят. Прямо тут и закенселят.");
				else Say("a", "No-no-no, no hands! Otherwise they'll kennel. They'll kennel right there.");
				break;
			case 63:
				Show("f", "Лево");
				StartDissolve("f", 0);
				if (language == 1) Say("f", "Серьёзно. Слезь со стола. ");
				else Say("f", "Seriously. Get off the table.");
				break;
			case 64:
				if (language == 1) Say("a", "Да че ты заладил: \"серьёзно, серьёзно\". Всё нормас, только уберите закуски. Эй, Сань, доставай аскорбинку, можешь даже на ебать меня с ней, разрешаю.", true);
				else Say("a", "What are you doing wrong: \"seriously, seriously\". Everything is fine, just take away the snacks. Hey, San, get the ascorbic acid, you can even fuck me with it, I allow it.", true);
				break;
			case 65:
				if (language == 1) Say("f", "Эй, парень. Не надо. Серьёзно, это уже слишком. ", true);
				else Say("f", "Hey man. Don't. Seriously, this is too much. ", true);
				break;
			case 66:
				EndDissolve("f");
				yield return new WaitForSeconds(0.5f);
				Show("s", "Лево");
				StartDissolve("s", 3);
				if (language == 1) Say("s", "Если не можешь помочь — не мешай. ");
				else Say("s", "If you can't help, don't interfere.");
				break;
			case 67:
				Dissolve("s", 0);
				if (language == 1) Say("s", "А ты, Андрюша, не переживай. Я всё для тебя уберу. ");
				else Say("s", "Don't worry, Andryusha. I'll clean everything for you.");
				break;
			case 68:
				EndDissolve("a");
				EndDissolve("s");
				yield return new WaitForSeconds(0.5f);
				StartDissolve("aa", 0);
				if (language == 1) Say("aa", "Тут же так режет глаза, и приходится признать хотя бы самому себе, что никакая это не ресничка.");
				else Say("aa", "Immediately it hurts my eyes, and I have to admit, at least to myself, that this is not an eyelash.");
				break;
			case 69:
				if (language == 1) Say("aa", "Ну как? Вспомнил?");
				else Say("aa", "Well, how? Did you remember?");
				break;
			case 70:
				st.step = 72;
				goto case 72;
			case 71:
				SetStats(new Dictionary<string, int> { { "Безумие", -1 } });
				if (language == 1) Say("aa", "Надо же… Я даже не понимаю, разочарован я или впечатлён.", true);
				else Say("aa", "Wow... I don't even know if I'm disappointed or impressed.", true);
				break;
			case 72:
				EndDissolve("aa");
				Fade(2f, language == 1 ? "Иллюзия воспоминания стирается в мгновение, и Андрей возвращается в свою неприятную реальность" : "The illusion of memories is erased in an instant, and Andrei returns to his unpleasant reality");
				yield return new WaitForSeconds(2f);
				yield return new WaitForEndOfFrame();
				NextCoroutine("B1");
				break;
		}
		st.CoroutineEnding();
	}
	private IEnumerator B1()
	{
		st.CoroutineBegining();
		switch (st.step)
		{
			case 0:
				Scene(0);
				SecondScene(0);
				PlayMusic(4);
				st.SetMaterial(0, new Dictionary<string, float> { { "_WaveSpeed", 2.5f }, { "_WaveAmplitude", 0.003f } });
				yield return new WaitForSeconds(1f);
				if (language == 1) Think("Чтобы отвлечься — психует, судорожно перебирая кучу словесного мусора в личке, надеясь зацепить хоть чье-нибудь важное слово.");
				else Think("To get distracted, he freaks out, convulsively sorting through a bunch of verbal garbage in a personal, hoping to catch at least someone's important word.");
				break;
			case 1:
				if (language == 1) Think("От холодного света монитора и оформления приложения уже резь в глазах. Бессмысленные твиты условного Славы сливаются с шутками Олега и Кирилла.");
				else Think("From the cold light of the monitor and the design of the application, it's already hurting your eyes. The meaningless tweets of conditional Slava merge with the jokes of Oleg and Kirill.");
				break;
			case 2:
				if (language == 1) Say("a", "Обхохочешься. Какой ты остроумный, прямо до колик, очередной \"супер смешной\" никнейм.");
				else Say("a", "Laughing. What a witty, right to colic, another \"super funny\" nickname you are.");
				break;
			case 3:
				if (language == 1) Think("С Твиттера переходит на другой сайт с другими ненавистными оттенками голубого — любимый ВК, откуда НАКОНЕЦ находит силы отправить хоть одно сообщение.");
				else Think("From Twitter, he goes to another site with other hateful shades of blue - his favorite VK, from where he FINALLY finds the strength to send at least one message.");
				break;
			case 4:
				if (language == 1) Say("\"Еще одна томбойка\"", "Нашла клёвый видос, вроде ещё не смотрели");
				else Say("\"Another tomboy\"", "Found a cool vid, didn't seem to watch it yet");
				Messenger(0, 0);
				PlaySound(0);
				break;
			case 5:
				if (language == 1) Think("А взгляд цепляется не за него, а за Женину аватарку.");
				else Think("And the look clings not to him, but to Zhenya's avatar.");
				Show("sh", "Центр", new Vector3(0.5f, 0.5f, 0), new Vector3(0, 1.25f, 0));
				StartDissolve("sh", 0);
				yield return new WaitForSeconds(1.5f);
				EndDissolve("sh");
				break;
			case 6:
				if (language == 1) Say("АНДРЮША СУКАЧЕВ", "Раз нашла — присылай, хули нет то.");
				else Say("ANDRYUSHA SUKACHEV", "Once you found it, send it in, fuck it.");
				Messenger(0, 1);
				PlaySound(0);
				break;
			case 7:
				if (language == 1) Say("АНДРЮША СУКАЧЕВ", "Только перестань мне выкать, когда волнуешься.");
				else Say("ANDRYUSHA SUKACHEV", "Just stop yelling at me when you're worried.");
				Messenger(0, 2);
				PlaySound(0);
				break;
			case 8:
				if (language == 1) Say("АНДРЮША СУКАЧЕВ", "Бесишь пиздец, Женя");
				else Say("ANDRYUSHA SUKACHEV", "You're pissed off, Zhenya");
				Messenger(0, 3);
				PlaySound(0);
				break;
			case 9:
				if (language == 1) Say("a", "Что дальше...");
				else Say("a", "What's next...");
				break;
			case 10:
				if (language == 1) Think("\"Еще одна томбойка\". В далеком 19 году пригласила прогуляться по Краснодару. Но не сама, а через свою лучшую подругу-однокурсницу.");
				else Think("\"Another tomboyka\". Back in 1919, she invited me to take a walk around Krasnodar. But not by herself, but through her best friend, classmate.");
				break;
			case 11:
				if (language == 1)
					ChoiceList(
					new string[] { "Забить", "Зацепиться за воспоминание" },
					new int[] { 0, 0 },
					new string[] { "B2", "B3" },
					new int[] { 0, 0 },
					new bool[] { true, true },
					new string[]{
			"<color=#FF00D1>Безумие</color>+1,\r\n<color=#32E9AB>Эскапизм</color>+1,\r\n<color=#6AEC49>Франческа</color>+1",
			"<color=#A8FFFC>Искренность</color>+1,\r\n<color=#FD9A00>Женя</color>+1"});
				else
					ChoiceList(
					new string[] { "Break all", "Hook on a memory" },
					new int[] { 0, 0 },
					new string[] { "B2", "B3" },
					new int[] { 0, 0 },
					new bool[] { true, true },
					new string[]{
				"<color=#FF00D1>Madness</color>+1,\r\n<color=#32E9AB>Escapism</color>+1,\r\n<color=#6AEC49>Francesca</color>+1 ",
				"<color=#A8FFFC>Sincerity</color>+1,\r\n<color=#FD9A00>Zhenya</color>+1"});
				break;
		}
		st.CoroutineEnding();
	}
	private IEnumerator B2()
	{
		st.CoroutineBegining();
		switch (st.step)
		{
			case 0:
				SetStats(new Dictionary<string, int> { { "Безумие", +1 }, { "Эскапизм", +1 }, { "Франческа", +1 } });
				Show("aa", "Центр");
				StartDissolve("aa", 0);
				yield return new WaitForSeconds(0.5f);
				if (language == 1) Say("aa", "И правильно. Ничего интересного там предсказуемо не будет.");
				else Say("aa", "That's right. Predictably, there won't be anything interesting there.");
				break;
			case 1:
				if (language == 1) Say("a", "Знаешь что, Андрейка? Я прекрасно знаю, что тебя не существует, но ты и сам это отлично осознаешь, не так ли?");
				else Say("a", "You know what, Andreika? I know very well that you don't exist, but you yourself are well aware of that, don't you?");
				break;
			case 2:
				if (language == 1) Say("a", "Потому что ты — это я. Но одному слушать Федины демки… Как-то не комильфо.");
				else Say("a", "Because you are me. But to listen to Fedya's demos alone... Somehow it's not comme il faut.");
				break;
			case 3:
				if (language == 1) Say("a", "Не в смысле, что они скучные, нет.");
				else Say("a", "Not in the sense that they are boring, no.");
				break;
			case 4:
				if (language == 1) Say("a", "Нормальное музло. Как в среднем по больнице.");
				else Say("a", "Normal muzlo. As the average for the hospital.");
				break;
			case 5:
				if (language == 1) Say("a", "Но ты блять просто представь!");
				else Say("a", "But you just fucking imagine!");
				break;
			case 6:
				if (language == 1) Say("a", "Только цссссс.");
				else Say("a", "Just sssss.");
				break;
			case 7:
				if (language == 1) Say("a", "Не пизди, короче, а представляй, что у нас Саня на бэках!");
				else Say("a", "Don't be a jerk, just imagine that we have Sanya on the backs!");
				break;
			case 8:
				PlayMusic(2);
				if (language == 1) Think("Он сам, потому что никого другого тут нет и никогда не было, закрывает глаза, пренебрежительно указав сигаретой на стол, небрежно стряхнув с нее пепел.");
				else Think("He himself, because there is no one else here and never was, closes his eyes, dismissively pointing his cigarette at the table, carelessly shaking off the ashes.");
				break;
			case 9:
				if (language == 1) Think("Музыку он включил заблаговременно. В голову по накурке начинают лезть одни пьяные образы.");
				else Think("He turned on the music in advance. Some drunken images start to creep into his head after a smoke.");
				break;
			case 10:
				Dissolve("aa", 1);
				if (language == 1) Think("Вот, например, Андрейка, изогнув губы в презрительной ухмылке, из чувства солидарности подыгрывает ему. Поэтому и ухмыляется так ядовито.");
				else Think("Here, for example, Andreika, curving his lips in a contemptuous smirk, plays along with him out of a sense of solidarity. That's why he smirks so venomously.");
				break;
			case 11:
				Dissolve("aa", 0);
				if (language == 1) Think("Нет, сладко.");
				else Think("No, sweet.");
				break;
			case 12:
				if (language == 1) Think("В его тщательно контролируемых Андрюшей речах одна патока, от которой вянут уши…");
				else Think("There is only molasses in his speeches, carefully controlled by Andryusha, from which the ears wither...");
				break;
			case 13:
				if (language == 1) Think("…в смысле стучит в висках, как от крепких сигарет.");
				else Think("... in the sense of knocking in the temples, like from strong cigarettes.");
				break;
			case 14:
				if (language == 1) Think("Если честно, Сукачеву просто забавно представлять, как альтер эго-тульпа запрыгивает на стол, не потревожив пепельницу — текстура просто накладывается на вполне реальный объект, и, закинув ногу на ногу, щелчком пальцев материализует точно такую же, как у Андрея, недокуренную сигарету.");
				else Think("To be honest, it's just funny for Sukachev to imagine how the alter ego-tulpa jumps on the table without disturbing the ashtray - the texture is simply superimposed on a very real object, and, having crossed his legs, materializes exactly the same as Andrey's with a snap of his fingers , half-smoked cigarette.");
				break;
			case 15:
				if (language == 1) Say("a", "Не, так дело не пойдёт. Футболка у тебя отстой. Нужно другую. Ту, что с нового альбома Саниного протеже.");
				else Say("a", "Nah, that's not going to work. Your T-shirt sucks. You need another one. The one from Sanya's protégé's new album.");
				break;
			case 16:
				if (language == 1) Say("a", "Да-да, ту заебатую.");
				else Say("a", "Yes, yes, that fucker.");
				break;
			case 17:
				if (language == 1) Say("a", "Ага, теперь норм.");
				else Say("a", "Yeah, okay now.");
				break;
			case 18:
				EndDissolve("aa");
				PlaySound(0);
				yield return new WaitForSeconds(0.5f);
				if (language == 1) Think("Докурить до фильтра ему не даёт гром из уведомлений. Причём он точно помнит, что всякую хуйню отключал в настройках приватности, так что это, должно быть, что-то очень важное.");
				else Think("Thunder from notifications doesn't let him finish smoking before the filter. And he definitely remembers that he turned off all the garbage in the privacy settings, so this must be something very important.");
				break;
			case 19:
				StartDissolve("aa", 0);
				yield return new WaitForSeconds(0.5f);
				if (language == 1) Say("aa", "Как думаешь, просекли, наконец, что ты пидор?", true, false);
				else Say("aa", "Do you think they finally figured out that you're a faggot?", true, false);
				break;
			case 20:
				if (language == 1) Say("a", "Будь добр, завались, а.");
				else Say("a", "Be kind, shut up, ah.");
				break;
			case 21:
				if (language == 1) Say("aa", "Почему? Разве Андрюша не научился ставить нормальные пароли?");
				else Say("aa", "Why? Hasn't Andryusha learned to set normal passwords?");
				break;
			case 22:
				if (language == 1) Say("a", "Я же сказал тебе заткнуться, не слышал?");
				else Say("a", "I told you to shut up, didn't you hear me?");
				break;
			case 23:
				if (language == 1) Say("aa", "Хотя нет, чего это я, конечно же научился.");
				else Say("aa", "But no, what have I learned, of course.");
				break;
			case 24:
				if (language == 1) Say("a", "Просто заткнись.");
				else Say("a", "Just shut up.");
				break;
			case 25:
				if (language == 1) Say("aa", "Его же не могли слить. Он же у нас такой умный, такой пиздатый.");
				else Say("aa", "They couldn't have leaked him. He's so smart, so fucked up.");
				break;
			case 26:
				if (language == 1) Say("a", "Заткнись.");
				else Say("a", "Shut up.");
				break;
			case 27:
				Dissolve("aa", 1);
				if (language == 1) Say("aa", "Да и к тому же не пидор он, один раз нещито..", true, false);
				else Say("aa", "And besides, he's not a fag, once unshielded..", true, false);
				break;
			case 28:
				StopMusic();
				PlaySound(1);
				Shake();
				Dissolve("aa", 0);
				if (language == 1) Say("a", "Да завали уже свое ебало!!!");
				else Say("a", "Shut your ass already!!!");
				break;
			case 29:
				if (language == 1) Think("Пепельница летит на пол, едва не захватив с собой клавиатуру. Но главное — летит она в тишине, ведь бит заткнулся сам собой. Видно, Андрей случайно клацнул по мышке.");
				else Think("The ashtray flies to the floor, almost taking the keyboard with it. But the main thing is that it flies in silence, because the beat shut up by itself. It can be seen that Andrey accidentally clicked on the mouse.");
				break;
			case 30:
				if (language == 1) Think("Он совершенно спокойно о вытирает обожженные губы тыльной стороной ладони, пока окурок валяется на паркете, чудом не устроив пожар");
				else Think("He calmly wipes his burnt lips with the back of his hand while the cigarette butt is lying on the floor, miraculously not starting a fire");
				break;
			case 31:
				EndDissolve("aa");
				Fade(2f);
				yield return new WaitForSeconds(2f);
				yield return new WaitForEndOfFrame();
				NextCoroutine("C1");
				break;
		}
		st.CoroutineEnding();
	}
	private IEnumerator B3()
	{
		st.CoroutineBegining();
		switch (st.step)
		{
			case 0:
				SetStats(new Dictionary<string, int> { { "Искренность", +1 }, { "Женя", +1 } });
				if (language == 1) Say("a", "А дальше что было? ");
				else Say("a", "What happened next?");
				break;
			case 1:
				if (language == 1) Think("Андрей обращается к себе, а не к Андрюше, да и вопрос риторический. Но все равно цепляется взглядом за кислотно-розовый всполох в темноте. ");
				else Think("Andrey refers to himself, not to Andryusha, and the question is rhetorical. But he still clings to the acid-pink flash in the dark.");
				break;
			case 2:
				if (language == 1) Say("a", "Так дело не пойдёт.");
				else Say("a", "That won't work.");
				break;
			case 3:
				if (language == 1) Think("Андрей скалится в темноту, и чтобы от воспоминаний не дай боже сумасшествие не отвлекло, зажмуривает глаза — раз уж придаваться воспоминанием, то только так.");
				else Think("Andrey is grinning into the darkness, and so that, God forbid, madness does not distract him from his memories, he closes his eyes - since he is attached to the memory, it's the only way.");
				break;
			case 4:
				if (language == 1) Say("a", "Осенью же это было? Где то в октябре? Мы ещё вдвоём мёрзли, но в ту кафешку так и не зашли? ");
				else Say("a", "Was it in autumn? Somewhere in October? We were still cold together, but we didn't go to that cafe?");
				break;
			case 5:
				PlaySound(1);
				if (language == 1) Think("Андрей откидывается на спинку стримерского кресла, но не выдерживает и ноги тоже куда то закидывает. Оттуда летит на пол что то подозрительно похожее на пустую бутылку портвейна.");
				else Think("Andrey leans back in the streamer's chair, but can't stand it and throws his legs somewhere too. From there, something suspiciously similar to an empty bottle of port flies to the floor.");
				break;
			case 6:
				if (language == 1) Say("a", "Ну и хуй с ней.");
				else Say("a", "Fuck her.");
				break;
			case 7:
				if (language == 1) Think("В его мычании невозможно разобрать ни слова, и посыл, особенно когда Андрей подчёркивает его широким жестом. ");
				else Think("In his lowing it is impossible to make out a word, and a message, especially when Andrey emphasizes it with a wide gesture. ");
				break;
			case 8:
				Show("aa", "Право");
				StartDissolve("aa", 0);
				if (language == 1) Say("aa", "Для кого выделываешься, если понимаешь, что кроме тебя здесь никого нет?");
				else Say("aa", "Who are you dressing up for when you realize there's no one else here but you?");
				break;
			case 9:
				if (language == 1) Think("А картинки в этой неестественно одинокой тишине такие яркие, будто бы Андрей уже успел принять.");
				else Think("And the pictures in this unnaturally lonely silence are so bright, as if Andrey has already managed to accept.");
				break;
			case 10:
				if (language == 1) Think("Но он абсолютно трезв, откинулся на спинку кресла и говорит сам с собой, полностью абстрагировавшись и от диалога с Женей, и от остальных пиздецки важных людей, об общении с которыми пару лет назад он мог только мечтать. ");
				else Think("But he is absolutely sober, leans back in his chair and talks to himself, completely disengaging from the dialogue with Zhenya, and from other fucking important people, whom he could only dream of communicating with a couple of years ago. ");
				break;
			case 11:
				Move("aa", "Право", "Лево", 2f);
				EndDissolve("aa");
				if (language == 1) Think("Просто откинулся и даже не зажёг сигарету, зажал между зубами и забыл о её существовании, вспоминая, в какое именно кафе они так и не попали. ");
				else Think("Just sat back and didn't even light a cigarette, stuck it between my teeth and forgot about its existence, remembering which cafe they never got to. ");
				break;
			case 12:
				if (language == 1) Say("a", "Вроде как роллы там какие-то предлагали за полцены?");
				else Say("a", "It seems like they offered some rolls there at half price?");
				break;
			case 13:
				if (language == 1) Think("Прокусив сигарету, он вспоминает, что не роллы, а рамен, и не за пол цены, а бесплатно, но с каким то хитрым условием. Они потом ещё сидели вдвоём на скамейке.");
				else Think("After biting a cigarette, he remembers that it's not rolls, but ramen, and not for half the price, but for free, but with some kind of tricky condition. Then they still sat together on the bench.");
				break;
			case 14:
				if (language == 1) Say("a", "Эй, ты.");
				else Say("a", "Hey you.");
				break;
			case 15:
				if (language == 1) Say("a", "Не хочешь мне помочь? Ты же там тоже был.");
				else Say("a", "Do you want to help me? You were there too.");
				break;
			case 16:
				if (language == 1) Think("Но вместо ответа перед глазами появляются воспоминания.");
				else Think("But instead of an answer, memories appear before my eyes.");
				break;
			case 17:
				Fade();
				yield return new WaitForSeconds(2f);
				Scene(7);
				PlayMusic(8);
				if (language == 1) Think(" ");
				else Think(" ");
				break;
			case 18:
				Show("sh", "Центр");
				StartDissolve("sh", 1);
				if (language == 1) Say("sh", "А пирсинг ты заранее снял?");
				else Say("sh", "Have you removed the piercing beforehand?");
				break;
			case 19:
				Zoom("sh", new Vector3(1.3f, 1.3f, 0), 1f);
				if (language == 1) Think("Девчонка пялится и даже не скрывает — устала, наверное. Так что суетится, изредка поправляя сумку правой рукой, и заглядывается на Сукачева.");
				else Think("The girl stares and doesn't even hide - she's probably tired. So she fusses, occasionally adjusting her bag with her right hand, and looks at Sukachev.");
				break;
			case 20:
				if (language == 1) Think("И не в глаза смотрит, нет. Мажет поплывшим от вина, остекленевшим взглядом по остуствуюещему в носу кольцу и снятым с ушей навесам. ");
				else Think("And he doesn't look into the eyes, no. He smears with a glassy, \u200b\u200bglassy look on the ring that is in the nose and the canopies removed from the ears. ");
				break;
			case 21:
				Zoom("sh", new Vector3(1f, 1f, 0), 1f);
				if (language == 1) Think("Андрюша пренебрежительно машет рукой, приговаривая: ");
				else Think("Andryusha scornfully waves his hand, saying: ");
				break;
			case 22:
				if (language == 1) Say("<color=#D63899>Анд</color><color=#5DD64E>рей</color>", "Хуй с ним.");
				else Say("<color=#D63899>And</color><color=#5DD64E>rey</color>", "Fuck him.");
				break;
			case 23:
				if (language == 1) Think("Женя многозначно кивает, не забывая поправить кепку, и, наконец, возвращает полупустую бутылку Андрюше. ");
				else Think("Zhenya nods meaningfully, not forgetting to adjust her cap, and finally returns the half-empty bottle to Andryusha. ");
				break;
			case 24:
				Move("sh", "Центр", "Лево", 1f);
				Show("a", "Центр");
				StartDissolve("a", 0);
				if (language == 1) Think("Благодарный кивок “Сукачева”, и начинается шоу: девчонка за представлением наблюдает пристально, и будто бы специально отстаёт, чтобы не наступать своими потертыми туфлями на пятки Андрюши. ");
				else Think("Sukachev's grateful nod, and the show begins: the girl watches the performance intently, and as if deliberately lags behind so as not to step on Andryusha's heels with her worn shoes. ");
				break;
			case 25:
				if (language == 1) Think("Она всего на несколько сантиметров его ниже, и смотрит с таким благоговением на не-Андрея, что сам заживо похороненный Андрей Сукачев и не желеет почти, что цирк этот не застает. ");
				else Think("She is only a few centimeters shorter than him, and she looks with such reverence at the non-Andrei that Andrey Sukachev, who is buried alive himself, almost does not wish that this circus does not catch him. ");
				break;
			case 26:
				st.SetMaterial(0, new Dictionary<string, float> { { "_WaveSpeed", 30f }, { "_WaveAmplitude", 0.01f } });
				PlayMusic(8, 1.2f);
				EndDissolve("a");
				EndDissolve("sh");
				if (language == 1) Think("Он блуждает от одного воспоминания к другому, от одной смешанной с желчью и желудочным соком сценой к другой, и не может понять, является ли этот кислотно-розовый ад частью флешбека тульпы, или это мысли его, настоящего. ");
				else Think("He wanders from one memory to another, from one scene mixed with bile and gastric juice to another, and can't figure out if this acid-pink hell is part of a tulpa's flashback, or if it's his thoughts, the real one.");
				break;
			case 27:
				if (language == 1) Think("Он сейчас наблюдает, как Андрюша гуляет с Женей?");
				else Think("Is he now watching Andryusha walking with Zhenya?");
				break;
			case 28:
				if (language == 1) Think("Или вспоминает, как Андрюша с Женей гулял, а сам сидит и думает, стоит ли ему, настоящему Андрею, отвечать настоящей Жене?…");
				else Think("Or does he remember how Andryusha walked with Zhenya, and he himself sits and thinks whether he, the real Andrey, should answer the real Zhenya?...");
				break;
			case 29:
				Fade();
				yield return new WaitForSeconds(2f);
				Scene(0);
				SecondScene(0);
				PlayMusic(4);
				if (language == 1) Think(" ");
				else Think(" ");
				st.SetMaterial(0, new Dictionary<string, float> { { "_WaveSpeed", 2.5f }, { "_WaveAmplitude", 0.003f } });
				break;
			case 30:
				Show("aa", "Лево", new Vector3(-1f, 1f, 0));
				StartDissolve("aa", 0);
				if (language == 1) Say("aa", "Было, Андрейка. Ты же сам попросил тебя подменить.");
				else Say("aa", "It was, Andreika. You yourself asked to replace you.");
				break;
			case 31:
				if (language == 1) Say("aa", "Ебал мозг твоей зазнобе так, что она аж растерялась и твою хорошенькую головку прекратила чайной ложечкой колупать.");
				else Say("aa", "Fucked your sweetheart's brain so that she was already confused and stopped picking your pretty head with a teaspoon.");
				Move("aa", "Лево", "Центр", 1f);
				yield return new WaitForSeconds(1f);
				Mirror("aa", new Vector3(-1f, 1f, 0), new Vector3(1f, 1f, 0));
				yield return new WaitForSeconds(0.5f);
				Zoom("aa", new Vector3(1.3f, 1.3f, 0), 1f);
				break;
			case 32:
				Dissolve("aa", 1);
				if (language == 1) Say("aa", "Женю просто надо было выебать. Сразу же оставила бы в покое твой сгнивший от солей мозг.");
				else Say("aa", "Zhenya just needed to be fucked. I would immediately leave your salt-rotted brain in peace.");
				break;
			case 33:
				PlaySound(14);
				if (language == 1) Say("aa", "ЧТО Я И СДЕЛАЛ!!!", true);
				else Say("aa", "WHAT I DID!!!", true);
				break;
			case 34:
				Zoom("aa", new Vector3(1.5f, 1.5f, 0), 1f);
				if (language == 1) Think("Андрей чувствует ледяную руку на своём плече. Её существовать не должно. И не бывает у людей таких холодных рук. Андрей зыбко ежится и старается её сбросить.");
				else Think("Andrey feels an icy hand on his shoulder. It shouldn't exist. And people don't have such cold hands. Andrey shudders unsteadily and tries to throw it off.");
				break;
			case 35:
				if (language == 1) Think("Тут же Андрей лишь пьяно ухмыляется, наслаждаясь прикосновением ктулху к его разгоряченной коже.  ");
				else Think("Here, Andrey just grins drunkenly, enjoying the touch of Cthulhu on his hot skin. ");
				break;
			case 36:
				if (language == 1) Say("aa", "Глазки закрывай, и я тебе покажу.");
				else Say("aa", "Close your eyes and I'll show you.");
				break;
			case 37:
				if (language == 1)
					ChoiceList(
					new string[] { "Оттолкнуть тульпу", "Закрыть глаза" },
					new int[] { 0, 0 },
					new string[] { "B3", "B3" },
					new int[] { 38, 41 },
					new bool[] { true, true },
					new string[] { "<color=#A8FFFC>Искренность</color>+1", "<color=#FF00D1>Безумие</color>+1" }
					);
				else
					ChoiceList(
					new string[] { "Push tulpa away", "Close eyes" },
					new int[] { 0, 0 },
					new string[] { "B3", "B3" },
					new int[] { 38, 41 },
					new bool[] { true, true },
					new string[] { "<color=#A8FFFC>Sincerity</color>+1", "<color=#FF00D1>Madness</color>+1" });
				break;
			case 38:
				SetStats(new Dictionary<string, int> { { "Искренность", +1 } });
				Zoom("aa", new Vector3(1f, 1f, 0), 1f);
				Dissolve("aa", 0);
				if (language == 1) Say("aa", "Надо же, какой плохой мальчик.");
				else Say("aa", "Wow, what a bad boy.");
				PlaySound(21);
				break;
			case 39:
				if (language == 1) Say("aa", "Тогда будь по-твоему, пусть будет по-плохому.");
				else Say("aa", "Then do it your way, let it be bad.");
				break;
			case 40:
				Zoom("aa", new Vector3(1.5f, 1.5f, 0), 1f);
				Dissolve("aa", 1);
				if (language == 1) Say("aa", "Твое жалкое существование принадлежит только мне.");
				else Say("aa", "Your miserable existence belongs only to me.");
				PlaySound(20);
				st.step = 42;
				goto case 42;
			case 41:
				SetStats(new Dictionary<string, int> { { "Безумие", +1 } });
				PlaySound(9);
				if (language == 1) Think("Андрей чувствует холодное дыхание у своего уха и, раз уж тульпа его так вежливо просит, закрывает глаза. ");
				else Think("Andrew feels cold breath at his ear and since his tulpa asks him so politely, he closes his eyes.");
				break;
			case 42:
				Fade(2f);
				yield return new WaitForSeconds(2f);
				Scene(7);
				PlayMusic(8, 0.78f);
				if (language == 1) Think(" ");
				else Think(" ");
				st.SetMaterial(0, new Dictionary<string, float> { { "_WaveSpeed", 4f }, { "_WaveAmplitude", 0.02f } });
				EndDissolve("aa");
				break;
			case 43:
				Show("sh", "Центр");
				StartDissolve("sh", 0);
				if (language == 1) Say("sh", "А можешь его надеть? ");
				else Say("sh", "Can you put it on?");
				break;
			case 44:
				Zoom("sh", new Vector3(1.2f, 1.2f, 0), 1f);
				if (language == 1) Think("Девчонка говорит первое, что приходит в голову, и тут же прикусывает изнутри щеку, увлечённо глазея по сторонам. Андрюша впереди идет и ухмыляется так мило, что скулы сводит — ");
				else Think("The girl says the first thing that comes to mind, and immediately bites her cheek from the inside, looking around with enthusiasm. Andryusha walks in front and grins so cute that her cheekbones flatten — ");
				break;
			case 45:
				Zoom("sh", new Vector3(1.4f, 1.4f, 0), 1f);
				if (language == 1) Think("Женя, Женечка. Прогулкой она уже пресытилась и ничего путного больше не скажет. Истории пойдут по второму кругу, как и вопросы: те, на которые он ответил и те, которые проигнорировал.");
				else Think("Zhenya, Zhenya. She's already fed up with the walk and won't say anything worthwhile anymore. The stories will go around the second circle, as well as the questions: those that he answered and those that he ignored.");
				break;
			case 46:
				Zoom("sh", new Vector3(1.6f, 1.6f, 0), 1f);
				if (language == 1) Think("Она сама устанет от них, затихнет и незаметненько начнёт поглядывать в телефон.");
				else Think("She will get tired of them herself, calm down and quietly start looking at her phone.");
				break;
			case 47:
				Zoom("sh", new Vector3(1.8f, 1.8f, 0), 1f);
				if (language == 1) Think("Скука да и только — Сукачев мог из каталога фанючек любую другую выбрать. ");
				else Think("Boreddom and only - Sukachev could choose any other from the fanyuchek catalog. ");
				break;
			case 48:
				Move("sh", "Центр", "Лево", 1f);
				Zoom("sh", new Vector3(1f, 1f, 0), 1f);
				Show("aa", "Право");
				StartDissolve("aa", 0);
				if (language == 1) Say("aa", "Они же все внутри пустые?");
				else Say("aa", "Are they all empty inside?");
				break;
			case 49:
				Zoom("sh", new Vector3(0.9f, 0.9f, 0), 1f);
				Move("sh", "Лево", "Лево", 1f, Vector3.zero, new Vector3(0, -0.4f, 0));
				if (language == 1) Say("aa", "Или как ты там говорил, а, ленивый мудак?", true);
				else Say("aa", "Or whatever you said, lazy asshole?", true);
				PlaySound(14);
				break;
			case 50:
				Zoom("sh", new Vector3(0.8f, 0.8f, 0), 1f);
				Move("sh", "Лево", "Лево", 1f, new Vector3(0, -0.4f, 0), new Vector3(0, -0.8f, 0));
				if (language == 1) Say("aa", "Даже не пытайся в ящик играть, я тебя вижу прекрасно, Андрейка.");
				else Say("aa", "Don't even try to play catch, I can see you perfectly, Andrey.");
				break;
			case 51:
				Zoom("sh", new Vector3(0.7f, 0.7f, 0), 1f);
				Move("sh", "Лево", "Лево", 1f, new Vector3(0, -0.8f, 0), new Vector3(0, -1.2f, 0));
				if (language == 1) Say("aa", "Андрейка, а, Андрейка?", true);
				else Say("aa", "Andreika, eh Andrey?", true);
				PlaySound(20, 1f);
				break;
			case 52:
				Zoom("sh", new Vector3(0.6f, 0.6f, 0), 1f);
				Move("sh", "Лево", "Лево", 1f, new Vector3(0, -1.2f, 0), new Vector3(0, -1.8f, 0));
				Dissolve("aa", 1);
				if (language == 1) Say("aa", "Туц-туц-туц, дарю?");
				else Say("aa", "Tuts-tuts-tuts, I give?");
				PlaySound(20, 1.2f);
				break;
			case 53:
				Zoom("sh", new Vector3(0.5f, 0.5f, 0), 1f);
				Move("sh", "Лево", "Лево", 1f, new Vector3(0, -1.8f, 0), new Vector3(0, -2.4f, 0));
				if (language == 1) Say("<color=#D63899>Анд</color><color=#5DD64E>рей</color>", "Повторяешься.");
				else Say("\u003ccolor\u003d#D63899\u003eAndes\u003c/color\u003e\u003ccolor\u003d#5DD64E\u003erei\u003c/color\u003e", "Repeat.");
				break;
			case 54:
				Zoom("sh", new Vector3(0.4f, 0.4f, 0), 1f);
				Move("sh", "Лево", "Лево", 1f, new Vector3(0, -2.4f, 0), new Vector3(0, -3f, 0));
				Dissolve("aa", 0);
				if (language == 1) Say("aa", "Чего же ты, Андрейка, так на неё... ");
				else Say("aa", "What are you, Andrey, so on her...");
				PlaySound(14, 1.1f);
				break;
			case 55:
				Zoom("sh", new Vector3(0.3f, 0.3f, 0), 1f);
				Move("sh", "Лево", "Лево", 1f, new Vector3(0, -3f, 0), new Vector3(0, -3.6f, 0));
				if (language == 1) Say("aa", "Эй, ты, разомлевший от светлой грусти?", true);
				else Say("aa", "Hey, are you mad with light sadness?", true);
				break;
			case 56:
				Zoom("sh", new Vector3(0.2f, 0.2f, 0), 1f);
				Move("sh", "Лево", "Лево", 1f, new Vector3(0, -3.6f, 0), new Vector3(0, -4.2f, 0));
				if (language == 1) Say("aa", "Вылезай на божий свет, пока я не передумал.");
				else Say("aa", "Get out into the open before I change my mind.");
				break;
			case 57:
				Zoom("sh", new Vector3(0.1f, 0.1f, 0), 1f);
				Move("sh", "Лево", "Лево", 1f, new Vector3(0, -4.2f, 0), new Vector3(0, -6f, 0));
				if (language == 1) Say("aa", "Или ты... ");
				else Say("aa", "Or are you...");
				break;
			case 58:
				Dissolve("aa", 1);
				if (language == 1) Say("<color=#D63899>Анд</color><color=#5DD64E>рей</color>", "Не можешь? ");
				else Say("<color=#D63899>And</color><color=#5DD64E>rey</color>", "Can't you? ");
				PlaySound(20, 1.2f);
				break;
			case 59:
				if (language == 1) Say("<color=#D63899>Анд</color><color=#5DD64E>рей</color>", "Зава... ");
				else Say("<color=#D63899>And</color><color=#5DD64E>rey</color>", "Shut... ");
				break;
			case 60:
				Shake();
				PlaySound(1);
				EndDissolve("aa");
				if (language == 1) Say("<color=#D63899>Анд</color><color=#5DD64E>рей</color>", "лись!");
				else Say("<color=#D63899>And</color><color=#5DD64E>rey</color>", "UP!");
				break;
			case 61:
				Zoom("sh", new Vector3(1f, 1f, 0), 1f);
				Move("sh", "Лево", "Центр", 1f, new Vector3(0, -4.8f, 0), new Vector3(0, 0, 0));
				if (language == 1) Think("Андрюша смеётся, но не для него. Андрюша смеётся для Жени, которая резко останавливаясь около свободной скамейки");
				else Think("Andryusha laughs, but not for him. Andryusha laughs for Zhenya, who abruptly stops near a free bench");
				break;
			case 62:
				if (language == 1) Say("<color=#D63899>Анд</color><color=#5DD64E>рей</color>", "Ну, раз хочется, давай наденем.");
				else Say("<color=#D63899>And</color><color=#5DD64E>rey</color>", "Well, if you want, let's put it on.");
				break;
			case 63:
				if (language == 1) Think("Сукачев снимает с плеча рюкзак, кидая его на скамейку, и сам кидается следом, только вот не как все — Андрюша запрыгивает на три покореженные временем перекладины.");
				else Think("Sukachev takes off his backpack from his shoulder, throwing it on the bench, and he himself rushes after him, but not like everyone else - Andryusha jumps on three crossbars warped by time.");
				break;
			case 64:
				if (language == 1) Say("sh", "Осторожно!", true);
				else Say("sh", "Caution!", true);
				break;
			case 65:
				PlaySound(4);
				if (language == 1) Think("Ответом ей служит заразительный Андрюшин смех.");
				else Think("Andryushin's infectious laughter serves as her answer.");
				break;
			case 66:
				if (language == 1) Think("Женя слово “осторожно” тянет, как маленькая девочка, и своими ножками в тяжёлых говнодавах  ломает октябрьский лёд с громким, тошнотворным хрустом. Грязные капли на капроновых колготках стекают за обитый мехом шиворот ботинок, но ей все равно.");
				else Think("Zhenya pulls the word \"carefully\" like a little girl, and breaks the October ice with her heavy shitty legs with a loud, nauseating crunch. Dirty drops on nylon pantyhose drip behind the fur-lined collar of her boots, but she doesn't care.");
				break;
			case 67:
				if (language == 1) Think("Женя — раскрасневшаяся от холода и вина, но все ещё мертвенно бледная девчушка — тянет к нему ледяные руки в перчатках без пальцев, касается плеча, отдергивая от выгнутой спинки скамейки, грозящей разбить ему череп: так красочно Сукачев откинулся назад. ");
				else Think("Zhenya - flushed from cold and wine, but still deathly pale girl - pulls her icy hands in fingerless gloves towards him, touches his shoulder, pulling away from the arched back of the bench, threatening to break his skull: Sukachev leaned back so colorfully. ");
				break;
			case 68:
				if (language == 1) Say("<color=#D63899>Анд</color><color=#5DD64E>рей</color>", "На, свой тоже протри.");
				else Say("<color=#D63899>And</color><color=#5DD64E>rey</color>", "Here, wipe yours too.");
				break;
			case 69:
				if (language == 1) Think("Сукачев ей кидает упаковку влажных салфеток, заблаговременно вытащив себе одну.");
				else Think("Sukachev throws a package of wet wipes at her, pulling out one for himself in advance.");
				break;
			case 70:
				if (language == 1) Think("Женька ловит, не отпуская его плеча. ");
				else Think("Zhenka catches without letting go of his shoulder. ");
				break;
			case 71:
				Show("aa", "Право", new Vector3(1f, -1f, 0));
				StartDissolve("aa", 1);
				Move("aa", "Право", "Право", 1f, new Vector2(0, 10f), new Vector2(0, 2f));
				PlaySound(20, 1.2f);
				if (language == 1) Say("aa", "Андрейка, Андрейка, Андрейка, туц-туц-туц, Андрейка. ");
				else Say("aa", "Andreika, Andreyka, Andreyka, tuts-tuts-tuts, Andrey.");
				break;
			case 72:
				Move("aa", "Право", "Право", 1f, new Vector2(0, 2f), new Vector2(0, 10f));
				if (language == 1) Think("Он будет напевать это, пока гуляет с Женей, чтобы контуженный «Андрейка» хотя бы знал, куда ему в розовом аду кричать «завались».");
				else Think("He will sing this while walking with Zhenya, so that the shell-shocked \"Andreika\" at least knows where to shout \"heaps\" in the pink hell");
				break;
			case 73:
				Fade(2f);
				yield return new WaitForSeconds(2f);
				EndDissolve("aa"); EndDissolve("sh");
				Scene(0);
				SecondScene(0);
				PlayMusic(4);
				if (language == 1) Think(" ");
				else Think(" ");
				st.SetMaterial(0, new Dictionary<string, float> { { "_WaveSpeed", 2.5f }, { "_WaveAmplitude", 0.003f } });
				break;
			case 74:
				if (language == 1) Say("sh", "Когда сказали, что твой блокнот никому не нужен *скриншот из популярного стендап шоу с ее любимым лысым мэном*");
				else Say("sh", "When they said that no one needs your notebook *screenshot from a popular stand-up show with her favorite bald man*");
				Messenger(0, 4);
				PlaySound(0);
				break;
			case 75:
				if (language == 1) Say("sh", "Когда спросили, че ты так вслушиваешься в эти ваши текста, а ты судья *снова скриншот*");
				else Say("sh", "When asked why you listen so hard to your texts, and you are the judge *screenshot again*");
				Messenger(0, 5);
				PlaySound(0);
				break;
			case 76:
				if (language == 1) Say("aa", "Всю беседу засрала.");
				else Say("aa", "I screwed up the whole conversation.");
				break;
			case 77:
				if (language == 1) Think("Но Андрей, наконец, смеётся хоть над чем-то.");
				else Think("But Andrew is finally laughing at something.");
				break;
			case 78:
				Fade(2f);
				yield return new WaitForSeconds(2f);
				yield return new WaitForEndOfFrame();
				NextCoroutine("C1");
				break;
			case 79:
				break;
		}
		st.CoroutineEnding();
	}
	private IEnumerator C1()
	{
		st.CoroutineBegining();
		switch (st.step)
		{
			case 0:
				Scene(0);
				SecondScene(0);
				PlayMusic(4);
				yield return new WaitForSeconds(1f);
				if (language == 1) Think("За черным свертком Андрюша собирается быстро. Что странно, не кидает в заклад ни экстази, ни какие-нибудь переоцененные соли — даже родненькие марки по итогу брать передумывает…");
				else Think("Andryusha is going to get a black bundle quickly. Strangely, he doesn't pawn either ecstasy or any overpriced salts - he even changes his mind about taking his own brands in the end...");
				break;
			case 1:
				if (language == 1) Think("Остается в заказе пока одна трава. Детское баловство.");
				else Think("There is only one herb left in the order. Childish pampering.");
				break;
			case 2:
				if (language == 1) Think("Ради этого ехать на другой конец Питера в нищие районы — идея так себе, но Сукачев, стерев с ресниц влагу рукавом черного лонга, отступать уже не намерен.");
				else Think("For the sake of this, going to the other end of St. Petersburg to the poor areas is a so-so idea, but Sukachev, having wiped moisture from his eyelashes with a black long sleeve, does not intend to retreat.");
				break;
			case 3:
				if (language == 1) Think("Поверх домашних шмоток он накидывает парку, не застегивая.");
				else Think("He wears a parka over his home clothes without fastening.");
				break;
			case 4:
				Show("aa", "Центр");
				StartDissolve("aa", 0);
				if (language == 1) Say("aa", "Серьезно? Ты кого обмануть пытаешься?");
				else Say("aa", "Seriously? Who are you trying to fool?");
				break;
			case 5:
				if (language == 1) Think("Встретившись глазами с зеркалом в коридоре, Андрей отворачивается от присутствия странного чувства.");
				else Think("Making eye contact with the mirror in the hallway, Andrey turns away from the presence of a strange feeling.");
				break;
			case 6:
				if (language == 1) Say("aa", "А сайт ты просто так не закрыл, да?", true, false);
				else Say("aa", "You didn't close the site just like that, did you?", true, false);
				break;
			case 7:
				if (language == 1) Think("Не глазей Сукачев несколько долгих секунд на Сашу со скринов, в даркнет за закладкой лезть бы вообще не пришлось…");
				else Think("Don't stare Sukachev for a few long seconds at Sasha from screenshots, you wouldn't have to go to the darknet for a bookmark at all...");
				break;
			case 8:
				if (language == 1) Think("Но случилось, как случилось.");
				else Think("But it happened, how it happened.");
				break;
			case 9:
				if (language == 1) Think("Андрей возвращается к компьютеру и кликает на все то, что когда-либо сам принимал и на то, что принимали при нем другие. За исключением, разве что, опиатов…");
				else Think("Andrey returns to the computer and clicks on everything that he has ever taken himself and on what others have taken with him. Except, perhaps, opiates...");
				break;
			case 10:
				if (language == 1) Say("aa", "Правильно. От себя не убежишь…");
				else Say("aa", "That's right. You can't run away from yourself...");
				break;
			case 11:
				Fade(2f, language == 1 ? "Улица Питера" : "Peter Street");
				yield return new WaitForSeconds(2f);
				EndDissolve("aa");
				PlayMusic(3);
				Scene(2);
				if (language == 1) Think("Подъезд он пролетел на сверхзвуковой скорости, а таксиста с тирадами про безруких водил и вовсе уже позабыл.");
				else Think("He flew over the entrance at supersonic speed, and he completely forgot about the taxi driver with tirades about armless ones.");
				break;
			case 12:
				Show("a", "Лево", new Vector3(-1f, 1f, 0));
				StartDissolve("a", 0);
				if (language == 1) Think("По дороге он обычно коротает время размышлениями о смысле того, что делает. Как правило, поглубже ныряя в любимое самобичевание.");
				else Think("On the way, he usually spends time thinking about the meaning of what he is doing. As a rule, diving deeper into his favorite self-flagellation.");
				break;
			case 13:
				if (language == 1) Think("Но иногда даже на страдальца Андрюшу обрушивается светлая мысль, что в этой депрессивной рутине нужно что-то менять.");
				else Think("But sometimes even the sufferer Andryusha gets a bright idea that something needs to be changed in this depressive routine.");
				break;
			case 14:
				if (language == 1) Think("Что нужно бросить наркотики. Начать жить, как все нормальные люди.");
				else Think("That you need to quit drugs. Start living like all normal people.");
				break;
			case 15:
				if (language == 1) Think("Дошел ли он до того просветления, при котором самостоятельно ложатся под капельницы с витаминками в рехаб? Конечно же нет.");
				else Think("Did he get to the point where he lays himself under a dropper with vitamins in rehab? Of course not.");
				break;
			case 16:
				if (language == 1) Think("Зато додумался до того, что такие перемены могут помочь обрести желаемое.");
				else Think("But I figured out that such changes can help you find what you want.");
				break;
			case 17:
				if (language == 1) Think("Только что ему нужно? Порой это неизвестно даже Андрюше. ");
				else Think("Just what does he need? Sometimes even Andryusha doesn't know it. ");
				break;
			case 18:
				if (language == 1) Think("Или лучше спросить: \"Кто ему нужен\"?..");
				else Think("Or better to ask: \"Who does he need\"?..");
				break;
			case 17 + 2:
				if (language == 1)
					ChoiceList(
					new string[] { "Саша", "Женя", "Никто" },
					new int[] { 1, 1, 0 },
					new string[] { "C1A1", "C1A2", "C1" },
					new int[] { 0, -1, 20 },
					new bool[] { gm.Stats["Саня"] >= 1, gm.Stats["Женя"] >= 1, true },
					new string[]{"Требуется:\r\n<color=#F0000E>Саня</color>>=1","Требуется:\r\n<color=#FD9A00>Женя</color>>=1",
			""});
				else
					ChoiceList(
					new string[] { "Sanya", "Zhenya", "Nobody" },
					new int[] { 1, 1, 0 },
					new string[] { "C1A1", "C1A2", "C1" },
					new int[] { 0, -1, 20 },
					new bool[] { gm.Stats["Саня"] >= 1, gm.Stats["Женя"] >= 1, true },
					new string[] { "Required:\r\n<color=#F0000E>Sanya</color>>=1", "Required:\r\n<color=#FD9A00>Zhenya</color>>=1", "" });
				break;
			case 18 + 2:
				if (language == 1) Say("a", "Не хочу сечас об этом думать, когда-нибудь потом.");
				else Say("a", "I don't want to think about it now, someday later.");
				break;
			case 19 + 2:
				Show("aa", "Право");
				StartDissolve("aa", 0);
				if (language == 1) Say("aa", "Так и знал, что ты на это забьешь.");
				else Say("aa", "I knew you'd give up on this.");
				break;
			case 20 + 2:
				if (language == 1) Say("aa", "Также как и всегда.", true, false);
				else Say("aa", "Same as always.", true, false);
				break;
			case 21 + 2:
				Fade();
				yield return new WaitForSeconds(2f);
				EndDissolve("aa");
				if (language == 1) Think("Заметив, что дождь за время поездки слегка стих, Андрей немедленно двигается по координатам на нужную точку через неприглядные бетонные домики.");
				else Think("Noticing that the rain has subsided slightly during the trip, Andrey immediately moves along the coordinates to the desired point through unsightly concrete houses.");
				break;
			case 22 + 2:
				if (language == 1) Think("Жёлтые стены домишек, деревянные окошки совсем небольшого размера и соответствующие настроению всего района гирлянды на шторах за стеклом.");
				else Think("Yellow walls of houses, wooden windows of very small size and garlands on curtains behind glass that correspond to the mood of the whole area.");
				break;
			case 23 + 2:
				if (language == 1) Think("И тут — внезапно в окнах замечает страшных кукол, провожающих прохожих стеклянными глазами.");
				else Think("And then - suddenly in the windows he notices scary dolls, seeing off passers-by with glassy eyes.");
				break;
			case 24 + 2:
				if (language == 1) Think("Они приводят его в дикий восторг — Матвеевич аж останавливается, чтоб получше рассмотреть их голубые платьишки, кружевные чепчики и пухлые розовые губки в изгибах нежной пугающей улыбки.");
				else Think("They bring him wild delight - Matveyevich already stops to get a better look at their blue dresses, lace caps and plump pink lips in the curves of a gentle frightening smile.");
				break;
			case 25 + 2:
				if (language == 1) Say("a", "Пол бутылки вина — маловато для похода за годовым запасом мескалина под надзором замерших фарфоровых кукол в питерских окнах.");
				else Say("a", "Half a bottle of wine is not enough for a trip for a year's supply of mescaline under the supervision of frozen china dolls in St. Petersburg windows.");
				break;
			case 26 + 2:
				if (language == 1) Think("Угрюмый после недолгих размышлений о своем моральном и физическом опустошении, Андрюша находит прикрытую камнем выбоину и смело отодвигает ее ногой. Раскопав несколько черных пакетиков, плотно обмотанных изолентой, он сразу отписывает анониму в личку, что все нашел.");
				else Think("Gloomy after a brief thought about his moral and physical devastation, Andryusha finds a pothole covered with a stone and boldly pushes it away with his foot. Having unearthed several black bags tightly wrapped with electrical tape, he immediately unsubscribes to an anonymous person that he found everything.");
				break;
			case 27 + 2:
				Thrill("a");
				PlaySound(2);
				if (language == 1) Think("Но тут Андрей оступается и чуть не давит подошвой какой-то мелкий объект.");
				else Think("But here Andrei stumbles and almost crushes some small object with his sole.");
				break;
			case 28 + 2:
				if (language == 1) Think("У самого камня и лунки под закладку лежит…");
				else Think("Near the stone itself and the hole for the bookmark is…");
				break;
			case 29 + 2:
				Dissolve("a", 1);
				if (language == 1) Say("a", "Это че, пульт?..", true, false);
				else Say("a", "Is this a remote control?..", true, false);
				break;
			case 30 + 2:
				Item(0);
				if (language == 1) Think("Что-то вроде детской игрушки, похожей на плеер, кислотно желтого цвета.");
				else Think("Something like a kid's toy that looks like a walkman, acid yellow.");
				break;
			case 31 + 2:
				if (language == 1)
					ChoiceList(new string[] { "Подобрать", "Не трогать" }, new int[] { 0, 0 }, new string[] { "C1", "C2" }, new int[] { 34, 0 },
					new bool[] { true, gm.Stats["Безумие"] <= 0 },
					new string[] { "", "Требуется:\r\n<color=#FF00D1>Безумие</color><=0" });
				else
					ChoiceList(new string[] { "Pick up", "Do not touch" }, new int[] { 0, 0 }, new string[] { "C1", "C2" }, new int[] { 34, 0 },
					new bool[] { true, gm.Stats["Безумие"] <= 0 },
					new string[] { "", "Required:\r\n<color=#FF00D1>Madness</color><=0" });
				break;
			case 32 + 2:
				Dissolve("a", 0);
				if (language == 1) Think("Андрюша за неведомой надобностью поднимает ее и пихает в карман, к закладке, даже не бросив на неё второго, подозрительного взгляда. ");
				else Think("Andryusha, for some unknown need, picks it up and shoves it into his pocket, to the bookmark, without even throwing a second, suspicious glance at her. ");
				break;
			case 33 + 2:
				if (language == 1) Say("a", "Дома разберусь, что это вообще может быть и нахуй оно мне надо.");
				else Say("a", "At home I'll figure out what it could be and why the fuck do I need it.");
				break;
			case 34 + 2:
				//EndDissolve("a");
				//yield return new WaitForSeconds(0.5f);
				Show("aa", "Право");
				StartDissolve("aa", 0);
				if (language == 1) Say("aa", "Разберешься, значит?");
				else Say("aa", "Understand, then?");
				break;
			case 35 + 2:
				if (language == 1) Say("a", "Не уверен…");
				else Say("a", "Not sure...");
				break;
			case 36 + 2:
				yield return new WaitForEndOfFrame();
				NextCoroutine("D1", 1);
				break;
		}
		st.CoroutineEnding();
	}
	private IEnumerator C2()
	{
		st.CoroutineBegining();
		switch (st.step)
		{
			case 0:
				if (language == 1) SandInfoMessage("<color=#6AEC49>Франческа</color> довольна вами");
				else SandInfoMessage("<color=#6AEC49>Francesca</color> pleased with you");
				Dissolve("a", 0);
				if (language == 1) Think("Лежит и лежит. Пульт и пульт. Может, и не пульт вовсе — если приглядеться, то больше похоже на плеер.");
				else Think("Lies and lies. Remote and remote. Maybe not a remote at all - if you look closely, it looks more like a player.");
				yield return new WaitForSeconds(1f);
				break;
			case 1:
				if (language == 1) Think("Андрей не приглядывается, ему как-то без разницы. Всё равно, не интересно, до лампочки… ");
				else Think("Andrey doesn't look closely, he somehow doesn't care. It doesn't matter, it's not interesting, it doesn't matter...");
				break;
			case 2:
				if (language == 1) Think("Он подбирает свою закладку, любовно укладывает в карман и разворачивается, чтобы уйти, как вдруг слышит громкий треск.");
				else Think("He picks up his bookmark, pockets it lovingly, and turns to leave when he hears a loud crack.");
				Move("a", "Лево", "Центр", 2f);
				yield return new WaitForSeconds(2f);
				PlaySound(2);
				Thrill("a");
				yield return new WaitForSeconds(1f);
				Mirror("a", new Vector3(-1f, 1f, 0), new Vector3(1f, 1f, 0));
				break;
			case 3:
				if (language == 1) Think("Чувствует что-то неприятное под правым ботинком и тут же поддевает это \"что-то\" носком.");
				else Think("Feels something unpleasant under the right shoe and immediately puts \"something\" toe on it.");
				break;
			case 4:
				if (language == 1) Think("Пластмасса раскололось на крупные, неровные кислотно-зеленые, острые по краям куски. И если к ним приглядеться, можно заметить, что с изнанки они влажно блестят.");
				else Think("The plastic has shattered into large, jagged, acid-green, sharp-edged chunks. And if you look closely, you can see that they have a wet sheen from the inside out.");
				break;
			case 5:
				if (language == 1) Say("a", "Мало того что игрушка — дерьмо, так в неё, судя по всему, ещё и нассали.");
				else Say("a", "Not only is the toy shit, it looks like it was also pissed in.");
				break;
			case 6:
				if (language == 1) Think("Андрей вытирает испачканую подошву о снег и разворачивается, чтобы уйти, но снова слышит треск. ");
				else Think("Andrey wipes his soiled sole on the snow and turns around to leave, but hears the crash again. ");
				Mirror("a", new Vector3(1f, 1f, 0), new Vector3(-1f, 1f, 0));
				yield return new WaitForSeconds(1f);
				PlaySound(2);
				Thrill("a");
				break;
			case 7:
				Mirror("a", new Vector3(-1f, 1f, 0), new Vector3(1f, 1f, 0));
				if (language == 1) Think("Предчувствуя неладное, он оглядывается и видит игрушку.");
				else Think("He looks around and sees the toy, sensing something is wrong.");
				break;
			case 8:
				if (language == 1) Think("Целую, совершенно новую, без единой царапины. На том же самом месте, где он её и раздавил.");
				else Think("I'm whole, brand new, not a single scratch. In the same place where he crushed her.");
				break;
			case 9:
				if (language == 1) Say("a", "Да, конечно...", true, false);
				else Say("a", "Yes, of course...", true, false);
				break;
			case 10:
				PlaySound(2);
				Thrill("a");
				if (language == 1) Think("Андрею не жалко, он давит её ещё раз.");
				else Think("Andrey is not sorry, he crushes her again.");
				break;
			case 11:
				PlaySound(2);
				Thrill("a");
				if (language == 1) Think("Снова треск, точно такой же, словно скребешь ногтями по стеклу. Андрей не сдаётся, пока не чувствует, что раздробил ее так, что назад уже не склеишь.");
				else Think("Crack again, exactly the same, as if you are scratching glass with your nails. Andrey does not give up until he feels that he has crushed it so that it cannot be glued back.");
				break;
			case 12:
				PlaySound(4);
				if (language == 1) Think("И, пьяно ухмыльнувшись, уходит. ");
				else Think("And, drunkenly grinning, he leaves. ");
				Mirror("a", new Vector3(1f, 1f, 0), new Vector3(-1f, 1f, 0));
				//yield return new WaitForSeconds(1f);
				Move("a", "Центр", "Право", 2f);
				break;
			case 13:
				Dissolve("a", 1);
				if (language == 1) Think("Думает, не стоило ли отвесить штуковине шутливый поклон, но голова забита другим, важным. И предвкушение, куда уж без этого.");
				else Think("Thinks he shouldn't have given the thing a playful bow, but his head is full of another, important one. And anticipation, where can I go without it.");
				break;
			case 14:
				PlaySound(2);
				Dissolve("a", 0);
				Thrill("a");
				if (language == 1) Think("Это \"важное\" разрезает пополам протяжный, раздражающий, будто издевающийся над Сукачевым треск. ");
				else Think("This \"important\" cuts in half a drawn out, annoying, as if mocking Sukachev crack. ");
				break;
			case 15:
				Show("aa", "Лево", new Vector3(-1f, 1f, 0));
				StartDissolve("aa", 0);
				PlaySound(20);
				if (language == 1) Say("aa", "Ахахаха", true, false);
				else Say("aa", "Ahahaha", true, false);
				Thrill("aa");
				Mirror("a", new Vector3(-1f, 1f, 0), new Vector3(1f, 1f, 0));
				yield return new WaitForSeconds(0.3f);
				Thrill("aa");
				yield return new WaitForSeconds(0.3f);
				Thrill("aa");
				yield return new WaitForSeconds(0.3f);
				Thrill("aa");
				yield return new WaitForSeconds(0.3f);
				Thrill("aa");
				break;
			case 16:
				if (language == 1) Think("Ухмылка превращается в гримасу");
				else Think("The smirk turns into a grimace");
				break;
			case 17:
				Dissolve("aa", 1);
				PlaySound(20);
				Thrill("aa");
				if (language == 1) Say("aa", "...Ахахаха", true, false);
				else Say("aa", "...Ahahaha", true, false);
				yield return new WaitForSeconds(0.3f);
				Thrill("aa");
				yield return new WaitForSeconds(0.3f);
				Thrill("aa");
				yield return new WaitForSeconds(0.3f);
				Thrill("aa");
				yield return new WaitForSeconds(0.3f);
				Thrill("aa");
				break;
			case 18:
				if (language == 1) Think("Андрей снова давит восстановившиеся игрушку, но на сей раз смотрит пристально, не отворачиваясь.");
				else Think("Andrey crushes the recovered toy again, but this time he looks intently, without turning away.");
				Move("a", "Право", "Центр", 1f);
				yield return new WaitForSeconds(1f);
				PlaySound(2);
				Thrill("a");
				break;
			case 19:
				Dissolve("aa", 0);
				PlaySound(2);
				Thrill("a");
				Item(0);
				if (language == 1) Think("Под ногами лежит целый плеер. ");
				else Think("There is a whole player under your feet. ");
				break;
			case 20:
				PlaySound(2);
				Thrill("a");
				if (language == 1) Think("Нет ни спецэффектов — ничего, даже треска — просто копеечная детская игрушка, прямиком из Андрюшеного счастливого детства. Только к той ещё обычно прилагалась жвачка.");
				else Think("There are no special effects - nothing, even cod - just a cheap children's toy, straight from Andryusheny's happy childhood. Only chewing gum was usually attached to that one.");
				break;
			case 21:
				if (language == 1) Say("aa", "Может, подберешь? Санечке подарить. Женя вон тебе футболку послала, а ты Сане - это!", true, false);
				else Say("aa", "Maybe you can pick it up? Give Sanya a present. Zhenya sent you a T-shirt, and you sent Sanya this!", true, false);
				break;
			case 22:
				if (language == 1)
					ChoiceList(new string[] { "Согласиться", "Послать нахер" }, new int[] { 1, 1 }, new string[] { "C2A1", "C2A2" }, new int[] { 0, 0 });
				else
					ChoiceList(new string[] { "Agree", "Send the fuck" }, new int[] { 1, 1 }, new string[] { "C2A1", "C2A2" }, new int[] { 0, 0 });
				break;
		}
		st.CoroutineEnding();
	}
}
