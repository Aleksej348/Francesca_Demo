using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story05 : Story
{
	private IEnumerator G1A1()
	{
		st.CoroutineBegining();

		switch(st.step)
		{
			case 0:
				SandInfoMessage("<color=#E02C37>Саня</color> благодарен вам");
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

	private IEnumerator G1A2()
	{
		st.CoroutineBegining();

		switch(st.step)
		{
			case 0:
				SandInfoMessage("<color=#FD9A00>Женя</color> благодарна вам");
				Think("Вместо ответа Андрей натыкается на крохотную прорезь, прямо под Беларусью:");
				break;
			case 1:
				Think("Он останавливается. Буквально замирает, некультурно пялясь на плату, на которой нет никаких опознавательных знаков, кроме пары из минуса и плюса. ");
				break;
			case 2:
				Say("a", "А ведь у каждой детской херни должны быть батарейки.");
				break;
			case 3:
				PlaySound(3);
				Think("Он ухмыляется и ещё раз повторяет, едва не утыкаясь носом во Франческу, шепча ей на метафорическое ухо");
				break;
			case 4:
				PlaySound(20);
				Say("aa", RichText("У каждой херни для детишек должна при себе быть батарейка!", "D4168B"));
				break;
			case 5:
				Think("Андрей не вздрагивает от крика в ухо — привык уже, но вот пара прохожих кидают на него брезгливые взгляды, жалость в которых куда отвратительнее этой самой брезгливости.");
				break;
			case 6:
				Think("Кто это — он без понятия, и его не трогают их выражения лица, которые бывают, когда в подошве лабутена прилипает дерьмо.");
				break;
			case 7:
				Think("Но все равно он засматривается, как подведенные алым губы шепчут подружке что-то там про соли. ");
				break;
			case 8:
				Think("Напоминает давно позабытый эпизод:");
				break;
			case 9:
				Think("Он сам, Женя, розововолосое чудище и Таня. ");
				break;
			case 10:
				Fade();
				yield return new WaitForSecondsRealtime(2f);
				Scene(8);
				PlayMusic(11);
				Think("Картинка перед глазами мутирует в уродливый гибрид реальности и грёз. ");
				break;
			case 11:
				Show("t", "Право", new Vector3(1.5f, 1.5f, 0));
				StartDissolve("t", 0);
				Think("Голубые глаза неизвестной «куклы» становятся Таниными — в радужке пара зелёных пятен разрастаются подобно плесени. ");
				break;
			case 12:
				Think("Таня смотрит на него снизу вверх, прожигая под кадыком дыру, и как бы невзначай касается его плеча своим. ");
				break;
			case 13:
				Zoom("t",Vector3.one,0.5f);
				Think("Тогда был не аэропорт и Андрей не ковырял ногтем Франческу — он стоял, разделяя собой двух «подружек», и делал вид, что не замечает, какие взгляды они на него кидают. ");
				break;
			case 14:
				Show("aa", "Лево", new Vector3(1f, 1f, 0));
				StartDissolve("aa", 0);
				Move("aa", "Лево", "Лево", 0.5f, new Vector2(0, -10f), new Vector2(0, 0));
				Say("aa", "Облизывается, будто тут твоя зазноба, а не ты.");
				break;
			case 15:
				Say("aa", "Эй, Андрюша, успел, пока меня не было, ещё тридцатку подписчиков набрать?");
				break;
			case 16:
				Say("aa", "Мы же с тобой, пока на метро ехали, всё подсчитали.");
				break;
			case 17:
				Say("aa", "Девятьсот семьдесят, Сукачев. И от тебя течёт тамблер герл, у которой полторы тысячи.");
				break;
			case 18:
				Dissolve("aa",1);
				PlaySound(14);
				Say("aa", "Совет да любовь.");
				break;
			case 19:
				EndDissolve("aa");
				yield return new WaitForSecondsRealtime(1f);
				Show("a","Лево");
				StartDissolve("a",0);
				yield return new WaitForSecondsRealtime(0.5f);
				Say("t", "С Федей-то мириться будешь?",true);
				break;
			case 20:
				Mirror("t", new Vector3(1f, 1f), new Vector3(-1f, 1f));
				Move("t", "Право", "Центр", 0.5f);
				Think("Таня по привычке дёргает его за край худи, привлекая к себе внимание. Привычка, выработанная за три месяца их «не отношений».");
				break;
			case 21:
				Dissolve("a",1);
				PlaySound(3);
				Say("a", "Да мы так-то и не ссорились.");
				break;
			case 22:
				PlaySound(10);
				Mirror("a",new Vector3(1f,1f), new Vector3(-1f,1f));
				Think("Андрей выдыхает дым ей в лицо, а она не закашливается, только улыбается, скрывая зубы, и переключает на айподсе не подходящий к ситуации трек на тот, что повеселее. ");
				yield return new WaitForSecondsRealtime(0.5f);
				Move("t", "Центр", "Право", 0.5f);
				break;
			case 23:
				Move("t", "Право", "Центр", 0.5f);
				Think("Улыбка становится не такой фальшивой, а пальчики продолжают держать за локоть. Как непослушного ребёнка. ");
				break;
			case 24:
				Say("t", "Правда? Ну тогда вдвойне хорошо. Извинился заранее за будущий посыл нахуй — всегда бы так.",true);
				break;
			case 25:
				Think("Она тянет это в своей раздражающей манере.");
				break;
			case 26:
				Say("a", "Тань, чесслово, заебала.",true);
				break;
			case 27:
				Move("a","Лево","Право",0.5f);
				yield return new WaitForSecondsRealtime(0.2f);
				Mirror("a", new Vector3(-1f,1f), new Vector3(1f,1f));
				Think("Андрей ловким движением выхватывает бутылку и под девичий смех пьёт из горла. Смеётся Таня чисто по инерции — на самом деле ей обидно. ");
				yield return new WaitForSecondsRealtime(1.5f);
				PlaySound(28,1.1f);
				Mirror("t", new Vector3(-1f, 1f), new Vector3(1f, 1f));
				break;
			case 28:
				PlaySound(23);
				Think("Андрей подгадал момент, когда она будет открывать, и окатил её мартини. ");
				yield return new WaitForSecondsRealtime(0.5f);
				Thrill("t");
				yield return new WaitForSecondsRealtime(0.5f);
				PlaySound2(3,1.1f);
				break;
			case 29:
				Say("t", "Эй, ты совсем уже?! Оно вообще-то новое было!!!",true);
				break;
			case 30:
				Say("t", "Жду деньги на карту за этот пиздец смешной перфоманс!",true);
				break;
			case 31:
				st.SetMaterial(0, new Dictionary<string, float> { { "_WaveSpeed", 3f }, { "_WaveAmplitude", 0.01f } });
				PlaySound(19);				
				Think("Андрей вместо ответа глотает Танин мартини, игнорируя, как нервный смех перерастает в раздражение. ");
				break;
			case 32:
				Mirror("t", new Vector3(1f, 1f), new Vector3(-1f, 1f));
				Say("t", "Радуйся, Женька.");
				yield return new WaitForSecondsRealtime(0.5f);
				break;
			case 33:
				Say("t", "Он не на каждом концерте такой смешной, а тут расстарался для тебя одной.",true);
				break;
			case 34:
				Show("sh","Лево");
				StartDissolve("sh", 0);
				Say("sh", "У меня салфетки есть. Влажные, целая пачка. Дать? ");
				break;
			case 35:
				Mirror("t",new Vector3(-1f,1f),new Vector3(1f,1f));
				Say("<color=#9BD7E2>Таня</color>?", "Вот идеальный для тебя вариант нарисовался — терпит любое твоё свинство.");
				break;
			case 36:
				Dissolve("a", 0);
				Think("Андрей согласно мычит, не отнимая от губ бутылку.");
				break;
			case 37:
				Say("<color=#9BD7E2>Таня</color>??", "Сглотнёт и добавки попросит.");
				break;
			case 38:
				Say("<color=#9BD7E2>Таня</color><color=#D63899>???</color>", "Ещё и платье, которое ты испортил, почистит.");
				break;
			case 39:
				EndDissolve("t");
				EndDissolve("a");
				EndDissolve("sh");				
				yield return new WaitForSecondsRealtime(1f);
				Show("aa", "Центр",new Vector3(1.5f,1.5f));
				StartDissolve("aa", 0);
				Move("aa", "Центр", "Центр", 0.5f, new Vector2(0, -10f), new Vector2(0, 0));
				Say("aa", "А может и с себя снять, отдать бедной подружке. Что угодно, чтобы загладить "+RichText("ТВОЮ",Color.green)+" вину.");
				break;
			case 40:
				PlayMusic(15);
				Shake();
				PlaySound(24);				
				Think("Бутылка летит на асфальт. ");
				break;
			case 41:
				Dissolve("aa", 1);
				PlaySound(20, 1.15f);
				Think("Вся его одежда становится мокрой, но Андрей этого не чувствует, заходясь в кашле — сухом и протяжном, грозящем оставить на ладошке ошметки лёгких.");
				yield return new WaitForSecondsRealtime(0.5f);
				PlaySound2(25);
				break;
			case 42:
				Say("aa", "Ох, чего же ты так некрасиво.");
				break;
			case 43:
				Dissolve("aa",0);
				Think("Несуществующий образ щёлкает языком у самого уха, легонько придерживая его за плечи.");
				break;
			case 44:
				Dissolve("aa",1);
				PlaySound(14,1.2f);
				Say("aa","Посмотри на них. Пальцами в тебя тыкают, пока ты тут желчью захлебываешься.");
				break;
			case 45:
				Think("«Андрюша» стоит к нему так близко, что Сукачев видит его кроссовки чётче своих.");
				break;
			case 46:
				Dissolve("aa",0);
				Say("aa", "Эй, Андрейка, слышишь меня? ");
				break;
			case 47:
				Say("aa", "Говорю, что бутылку они оплачивают, а не тебя, торчка.");
				break;
			case 48:
				Think("Перед лицом щёлкают пальцами так, что в глазах рябит странной, неправильной, слишком блеклой радугой. ");
				PlaySound(26);
				yield return new WaitForSecondsRealtime(0.5f);
				PlaySound2(26,1.1f);
				break;
			case 49:
				Think("Щёлкают, щёлкают, щёлкают — так раззадоривают взбесившуюся от боли в простреленной лапе шавку, чтобы бросилась наконец, и можно было её добить. ");
				PlaySound(26,0.9f);
				yield return new WaitForSecondsRealtime(0.7f);
				PlaySound2(26,1.05f);
				yield return new WaitForSecondsRealtime(0.9f);
				PlaySound(26,1.15f);
				break;
			case 50:
				Think("Только вот можно не успеть.");
				PlaySound(26);
				break;
			case 51:
				Say("aa", "Только вот можно не успеть…");
				break;
			case 52:
				Dissolve("aa", 1);				
				Say("aa", "Как хорошо быть тульпой.");
				break;
			case 53:
				PlaySound(20,1.1f);
				Say("aa", "Я понимаю тебя лучше, чем ты сам, а ты в ответ понимаешь меня.");
				break;
			case 54:
				Think("Безумные серые глаза напротив него и бешеный оскал. Остальное меркнет. ");
				break;
			case 55:
				EndDissolve("aa");
				Think("Секунда, и этого черта рядом с Сукачевым нет — он нависает над бледной Женей. Та стоит по правую руку от опустившегося на грязный асфальт Андрея. ");
				break;
			case 56:
				Show("sh","Право",new Vector3(-1.3f,1.3f));
				Show("t", "Лево", new Vector3(1.3f,1.3f));
				StartDissolve("sh",0);
				StartDissolve("t",0);
				Think("Вместо того чтобы сжимать его худи в нерешительной попытке поднять, как это делает такая же бледная Таня, она в отчаянии сжимает брелок от ключей. ");
				break;
			case 57:
				Think("А вот разбившаяся бутылка мартини под рукой есть.");
				break;
			case 58:
				Think("Андрей вырывает руку из Таниного захвата, и, сжимая в ладонях горлышко розочкой, бросается вперёд, ведь:");
				break;
			case 59:
				Shake();
				PlaySound(24,0.8f);
				EndDissolve("sh");
				EndDissolve("t");
				Say("a", "Андрюша, ты в край заебал!!");
				break;
			case 60:
				st.SetMaterial(0, new Dictionary<string, float> { { "_WaveSpeed", 3f }, { "_WaveAmplitude", 0.02f } });
				PlaySound(25,1.1f);
				Think("Женя не успевает перевести взгляд с пустоты на Сухачева — он валится на колени у её ног, закашливаясь до рвоты. Женя инстинктивно отступает, но не чтобы уйти от его замаха. ");
				break;
			case 61:
				Think("Она смотрит на скрюченного в агонии Андрея, переводя взгляд голубых глаз на катящуюся в сторону «розочку». ");
				break;
			case 62:
				Think("Момент осознания такой яркий — как когда обманом подруги затянули на ужастик в 3D. Такие детские ассоциации, но ничего страшнее Женя за свою жизнь не помнит. ");
				break;
			case 63:
				Think("Женя с детства боится женских криков, а Таня кричит особенно громко и пронзительно. И даже сквозь её крик слышно звук упавшего на асфальт тела. ");
				break;
			case 64:
				PlaySound(12, 0.8f);
				Think("Таня кричит, и Женя вздрагивает, отступает назад. Таня кричит так, что Женя затыкает уши. Крики складываются в слова, но слов этих Женя не слышит. ");
				break;
			case 65:
				Think("Зато слышит Андрюша.");
				break;
			case 66:
				StartDissolve("t", 0);
                Say("t", "Думаешь, это смешно?? ");
				break;
			case 67:
				Say("t", "Торч ебанный!! ", true);
				break;
			case 68:
				Show("aa","Право",new Vector3(1.3f,1.3f));
				StartDissolve("aa", 0);
				Say("aa", "Да, да, милая, ты права.");
				break;
			case 69:
				Say("aa", "Сукачев — наш с тобой любимый торч.",true);
				break;
			case 70:
				PlaySound(7);
				Say("a", "Кха-кха");
				break;
			case 71:				
				Say("a", "Акха-кха за… ");
				break;
			case 72:
				Say("a", "Кха.. вались!!! ");
				break;
			case 73:
				EndDissolve("t");
				Move("aa","Право","Центр",1f);
				Zoom("aa",new Vector3(1.5f,1.5f),1f);
				Say("aa", "А чего так?");
				break;
			case 74:
				Say("aa", "Ты же меня для этого и создал.");
				break;
			case 75:
				Say("aa", "Но ты не волнуйся. Я принимаю стоп-слова.");
				break;
			case 76:
				Dissolve("aa", 1);
				Say("aa", "ТОЛЬКО ВОТ С ТОБОЙ У МЕНЯ ЛАЙФСТАЙЛ!! ");
				break;
			case 77:
				Thrill("aa");
				PlaySound(20, 1.1f);
				Say("aa", "*смеется*");
				break;
			case 78:
				Say("aa", "ТАК ЧТО РАДУЙСЯ, АНДРЕЙ, ВОТ ОН Я.");
				break;
			case 79:
				Dissolve("aa",2);
				Say("aa", "ВЕСЬ ТВОЙ!!! ");
				break;
			case 80:
				Say("a", "ЗАВАЛИ СУКА ПАСТЬ!!! ");				
				break;
			case 81:
				Zoom("aa",new Vector3(2f,2f),1f);
				Move("aa","Центр",1f,new Vector3(0,-1f));
				Dissolve("aa", 3);
				Say("aa", "НЕТ.");
				break;
			case 82:
				Shake();
				PlaySound(24, 0.8f);
				Think("В Андрюшу летит подвернувшиеся под руку целёхенькая бутылка Балтики. Летит, да так и пролетает мимо, ведь своего тела у Андрюши нет. ");
				break;
			case 83:
				Dissolve("aa",2);
				Say("aa", "А чего так слабо? ");
				break;
			case 84:
				Think("Андрей целится в голову попавшейся под руку ржавой консервной банкой. Та  оказывается слишком тяжёлой и валится из ослабевших пальцев, отпечатавшись на ладони темно-бордовой кровью. ");
				break;
			case 85:
				PlaySound(8);
				Say("a", "Тебя тут быть не должно!!! ");
				break;
			case 86:
				Dissolve("aa", 0);
				Say("aa", "Да, Андрейка, я тот самый неудавшийся аборт, который ты обещал Танюше! ");
				break;
			case 87:
				Say("aa", "ЦЕЛЬСЯ ЛУЧШЕ.");
				break;
			case 88:
				Dissolve("aa", 3);
				Say("aa", "ПАПА");
				break;
			case 89:								
				Think("Андрюша делает то, что делал весь вечер: уводит его всё дальше от мертвенно бледной, потерянной Жени, сжимающей трясущимися пальцами свой рюкзачок. ");
				break;
			case 90:
				EndDissolve("aa");
				Think("От уставшей пытаться докричаться до него Тани, уже вызывающей скорую психиатрическую помощь. ");
				break;
			case 91:
				Think("Андрей ему за это благодарен: в их болоте для троих попросту не хватит места. Когда протрезвеет, на то, что чуть не снёс в пьяном угаре Жене голову, он скажет иронично — «повезло».");
				break;
			case 92:
				Think("И привычно чокнется с монитором мартини, чествуя сожравшую совесть ненависть и вечный, горячий на языке стыд. ");
				break;
			case 93:
				Think("Андрюша очевидную ремарку не озвучивает, но она так ясно читается в его серых глазах… ");
				break;
			case 94:
				Think("Сейчас Андрею так хорошо. Адреналин и есть тот самый чистый кайф, на фоне которого любая принятая таблетка не то что блёкнет… ");
				break;
			case 95:
				Say("a", "Без таблетки кайф был бы настолько сильный, что у меня бы крышу снесло.");
				break;
			case 96:
				PlaySound(3,1f);
				Say("a", "Напрочь бы снесло…");
				break;
			case 97:
				Think("За собственным смехом он и не замечает, как руки касаются бетона, и он снова задыхается. И его снова рвёт. ");
				break;
			case 98:
				StartDissolve("aa", 0);
				Say("aa", "Понимаю.");
				break;
			case 99:
				Think("Андрюша выглядит таким же больным, как и он. ");
				break;
			case 100:
				Say("a", "Херово, наверное, тело с торчком делить?. ");
				break;
			case 101:
				Dissolve("aa",1);
				PlaySound(14);
				Say("aa", "*смеется*");
				break;
			case 102:
				Say("aa", "«Херово» — не то слово.");
				break;
			case 103:
				Fade();
				yield return new WaitForSecondsRealtime(2f);
				st.SetMaterial(0,new Dictionary<string,float> { { "_WaveSpeed",3f },{ "_WaveAmplitude",0.006f } });
				Scene(6);
				EndDissolve("aa");
				PlayMusic(5,0.8f);
				Say("a","И после этого я так и не возместил ей похеренного тогда из-за меня зайца.");
				break;
			case 104:
				Say("a","И того, что она помогала Федьке паковать меня в такси…");
				break;
			case 105:
				Say("a","И кто-то из них ещё врал санитарам, что я уже куда то ушёл, и заплатил за ложный вызов…");
				break;
			case 106:
				Say("a","От Феди и Таньки я уже откупился, осталась Женя.");
				break;
			case 107:
				Say("a","Как думаешь, машины времени ей хватит? ");
				break;
			case 108:
				Think("Он всё ещё держит глаза закрытыми, пытаясь успокоить мечущиеся под тонкими веками зрачки. ");
				break;
			case 109:
				Say("a","Короче, Франческа…");
				break;
			case 110:
				Say("a","Отдам тебя Женьке. Пусть хоть что-то напоминает ей обо мне.");
				break;
			case 111:
				Say("a","И если попросит твои батарейки в своего зайца — ты уж поделись с ней.");
				break;
			case 112:
				Say("a","Будь хорошей девочкой.");
				break;
			case 113:
				Say("a","А, и ещё кое-что.");
				break;
			case 114:
				Say("a","Последнее желание перед последним желанием, окей? ");
				break;
			case 115:
				Say("a","Раздели нас с Андрюшей.");
				break;
			case 116:
				Say("a","Пусть у него свой мозг будет.");
				break;
			case 117:
				Say("a","Не торчковый.");
				break;
			case 118:
				Show("aa","Право",new Vector3(1f,1f));
				StartDissolve("aa",0);
				Say("aa","Вроде не курил, а такую чушь несёшь.");
				break;
			case 119:				
				Think("Сухачев смеётся.");
				PlaySound(27);
				yield return new WaitForSecondsRealtime(1f);
				Dissolve("aa",1);
				break;
			case 120:			
				Think("Франческа молчит. ");
				break;
			case 121:
				Dissolve("aa",0);
				Think("Приходится цокнуть языком и подобрать чудом не разбившуюся машину времени. ");
				break;
			case 122:				
				Say("a","Не слышишь? ");
				break;
			case 123:
				Move("aa","Центр",1f);
				EndDissolve("aa");
				Say("a","Или не хочешь к Жене? ");
				break;
			case 124:
				PlaySound(26);				
				Think("Андрей вздрагивает от резкого щелчка пальцами прямо перед носом.");
				break;
			case 125:
				Think("С удивлением переводит взгляд на сидящего перед ним на корточках Андрюшу.");
				break;
			case 126:
				st.SetMaterial(0,new Dictionary<string,float> { { "_WaveSpeed",3f },{ "_WaveAmplitude",0.02f } });
				PlaySound(22,0.9f);
				Show("aa","Центр");
				StartDissolve("aa",4);				
				Say("aa",RichText("Да трезв, просто думаю…","92EF97"));
				break;
			case 127:
				Say("aa",RichText("Честность.","92EF97"));
				break;
			case 128:
				Say("aa",RichText("Стоит ли она того? ","92EF97"),true);
				break;
			case 129:
				Think("Андрей улыбается, тяжело опираясь на стену. ");
				break;
			case 130:				
				Think("Голова идёт кругом, но силуэт Андрюши перед глазами чёткий. Вокруг него мир силится обвести себя вокруг горизонта — люди плывут куда-то, пряча от Андрея лица, а Андрюша — нет. ");
				break;
			case 131:
				Think("Андрюша чёткий. ");
				break;
			case 132:
				Say("a","Хотя я и так знаю, что да, только это не она была.");
				break;
			case 133:
				Say("a","Про бабулю — ложь.");
				break;
			case 134:
				Say("a","И про мозг для тебя тоже.");
				break;
			case 135:
				Say("a","Про Женьку — особенно наглый пиздёж.");
				break;
			case 136:
				Say("a","Я не хочу отдавать ей Франческу. ");
				break;
			case 137:
				Say("a","Я хочу, чтобы Франческа починила её зайца.");
				break;
			case 138:
				Say("a","Он же был этим? ");
				break;
			case 139:
				Item(12);
				Think("Сукачев разворачивает для Андрюши выпавшую из Франчески записку:");
				break;
			case 140:
				Think("«"+RichText("22-18-1-15-25-6-19-12-1",Color.green)+" и их отличие от классической"+RichText("14-1-26-10-15-29 21-5-1-25-10",Color.green)+"»");
				break;
			case 141:
				Think("У "+RichText("14-1-26-10-15-29 21-5-1-25-10",Color.green)+" выбранная точка в пределах 10 лет от точки, в которой вы их активировали, запоминается программой, которая отнюдь не бесконечна, и зависит от объёма батареи. Расчетное время пребывания в выбранной точке зависит от объёма батареи, но не может превышать 12 часов, иначе вы рискуете её сломать и стереть себя из существования.");
				break;
			case 142:
				Think(RichText("22-18-1-15-25-6-19-12-1",Color.green)+" же:");
				break;
			case 143:
				Think("1.Черпает силу не из батарейки, а из "+RichText("9-6-13-7-15-16-4-16 19-16-13-15-24-1 — 1-19-20-6-18-16-10-5-1, 18-1-9-14-6-18-16-14 19-17-13-21-20-16-15",Color.green)+" обладающего "+RichText("18-1-9-21-14-16-14",Color.green));
				break;
			case 144:
				Think("2.Может переместить вас в любую выбранную точку. Но помните, что сила "+RichText("9-6-13-7-15-16-4-16 19-16-13-15-24-1",Color.green)+" находится за пределами человеческого понимания, и вы играете с огнём, для своей вселенной чуждым.");
				break;
			case 145:
				Think("Так что играйте с умом, и помните:");
				break;
			case 146:
				Think(RichText("22-18-1-15-25-6-19-12-1 18-1-9-21-14-15-1",Color.green)+"и "+RichText("14-1-26-10-15-29 21-5-1-25-10",Color.green)+" рядом с ней создают помехи");
				break;
			case 147:
				Say("a","«Машиной удачи»? ");
				break;
			case 148:
				Say("a","Женя её сломала, пытаясь вытащить меня из бэд трипа?");
				break;
			case 149:
				Say("a","Я почему-то совсем не удивлён.");
				break;
			case 150:
				PlaySound(27,1.1f);
				Say("a","*смеётся*");
				break;
			case 151:
				Say("aa","Ты там что-то про мозги затирал.",true);
				break;
			case 152:
				Say("aa","Давай, продолжай!");
				break;
			case 153:
				Say("aa","Мне пиздец как интересно тебя, Андрейка, послушать!");
				break;
			case 154:
				Zoom("aa",new Vector3(1.5f,1.5f),1f);
				Dissolve("aa",1);
				Think("Андрюша перемещает вес на колени, и улыбается Андрею в лицо — их отделяет какая-то сотая фотона, что было бы невозможно физически, не будь Андрюша всего лишь плодом его воображения.");
				break;
			case 155:
				Say("a","А, это? ");
				break;
			case 156:
				Say("a","Ну пусть сюрпризом будет, раз прослушал.");
				break;
			case 157:
				PlaySound(4);
				Say("a","*посмеивается*");
				break;
			case 158:
				Say("a","Исполни это, Франческа, и можешь быть свободна.");
				break;
			case 159:
				Say("a","(шёпотом) Смотри, сейчас шоу будет.");
				break;
			case 160:
				PlaySound(26);
				Think("Андрей подмигивает ему и щёлкает пальцем по кнопке «плей», точно так же, как любит делать Андрюша, только тот пальцами щёлкает. Потому что у него не было Франчески — но эту несправедливость Сукачев исправил. ");
				break;
			case 161:
				Think("Щелчок ни к чему не приводит, если не считать того, что Сухачева догнало то самое воспоминание, от которого он так удачно сбежал в реальность. ");
				break;
			case 162:
				Think("Не спас его манифест про мозги — Андрей как наяву видит Федю, а руку сводит судорогой. ");
				break;
			case 163:
				Think("Он цепляется в предплечье, в безуспешной попытке остановить спазмы и рассмеялся бы, но сейчас не до смеха. Тяжело, не по касательной, впечатывается затылком в стену:");
				break;
			case 164:
				Fade();
				yield return new WaitForSecondsRealtime(2f);
				EndDissolve("aa");
				Scene(8);
				Show("f","Центр",new Vector3(1f,1f));
				StartDissolve("f",0);
				Say("f","Блять, поставь его на место");
				PlayMusic(6,0.95f);
				break;
			case 165:
				Say("f","Приедет скорая, тогда и потащим, если сами занести не смогут");
				break;
			case 166:
				Say("f","Это я-то клоун?",true);
				break;
			case 167:
				Say("f","Нет уж, продолжай, очень интересно послушать");
				break;
			case 168:
				Say("f","Ты тоже послушай, очень симптоматично у Сукачева обычно выходит",true);
				break;
			case 169:
				Say("f","Если тебе, конечно, не хватило того, что он на тебя пол печени выблевал ");
				break;
			case 170:
				Say("f","Блять, всю минералку выдул… ");
				break;
			case 171:
				Show("sh","Право",new Vector3(-1f,1f));
				StartDissolve("sh",0);
				Move("f","Лево",0.5f);
				Say("sh","Я там круглосуточный магазин видела, могу сбегать, он не так далеко… ");
				break;
			case 172:
				Say("f","Я сам тут, заблудишься ещё, а тут хоть камеры",true);
				break;
			case 173:
				Show("aa","Центр",new Vector3(1f,-1f),new Vector3(0,10f));
				Move("aa","Центр",0.4f,new Vector3(0,2f));
				StartDissolve("aa",0);
				Say("aa","А знаешь, что самое забавное, Андрейка? ");
				break;
			case 174:
				Dissolve("aa",1);
				PlaySound(14);
				Say("aa","Вы там были, и магазин этот не работает, одна вывеска осталась");
				break;
			case 175:
				Move("aa","Центр",0.5f,new Vector3(0,10f));
				Move("f","Лево",0.5f,new Vector3(0,-10f));
				Move("sh","Право",0.5f,new Vector3(0,-10f));
				ZoomBackground(new Vector3(10f,10f),2f);
				yield return new WaitForSecondsRealtime(1f);
				yield return StartCoroutine(act.timeTravel("Комната Жени\r\n27.11.2020 12:35",9,14,13));
				ZoomBackground(new Vector3(1f,1f),0.1f);
				Scene(9);				
				break;
			case 176:
				SetAllButtons(true);
				Show("sh","Лево",new Vector3(1f,1f));
				StartDissolve("sh",0);
				Say("sh","Вроде всё.");
				break;
			case 177:
				Say("sh","Тебе даже идёт",true);
				break;
			case 178:
				Say("sh","А главное, не будешь  наполнитель терять"); 
				break;
			case 179:
				Say("sh","Хоть кто из нас двоих не будет");
				break;
			case 180:
				PlaySound(28);
				Thrill("sh");
				Say("sh","*смешок*");
				break;
			case 181:
				Say("sh","Правда у людей это не синтепон",true);
				break;
			case 182:
				Say("sh","Знаешь… Знать, что ты меня больше не слышишь, на самом деле хорошо");
				break;
			case 183:
				Say("sh","Это, наверное, ужасно: говорить с человеком, который скорее умрёт, чем тебя услышит");
				break;
			case 184:
				Say("sh","И так глупо.");
				break;
			case 185:
				Say("sh","Очень-очень глупо…");
				break;
			case 186:
				Say("sh","Хотела бы я выбрать красную таблетку, заставляющую верить, что мы в матрице");
				break;
			case 187:
				Say("sh","Вместо синей: «принять и смириться» ");
				break;
			case 188:
				Item(0);
				EndDissolve("sh");
				Say("fr","Жалость");
				break;
			case 189:
				Say("fr","Огорчение");
				break;
			case 190:
				Say("fr","Правда ");
				break;
			case 191:
				Say("fr","Франческа");
				break;
			case 192:
				Say("fr","Существование ");
				break;
			case 193:
				Say("fr","Подарок");
				break;
			case 194:
				Say("fr","ОТ "+RichText("АНДРЕЯ",Color.green));
				break;
			case 195:
				Fade(4f,language==1 ? "Аэропорт\r\n27.11.2020 12:37" : "Airport\r\n27.11.2020 12:37");
				yield return new WaitForSecondsRealtime(2f);
				Scene(5);
				PlayMusic(13);
				Think("");
				break;
			case 196:
				Say("aa","Жень? ");
				break;
			case 197:
				Say("aa","Я в Краснодаре буду через четыре часа.");
				break;
			case 198:
				Say("aa","Погуляем? ");
				break;
			case 199:
				st.CanSkip(false);
				gm.act.CanTap=false;
				SetAllButtons(false);
				Fade(10f,"+");
				yield return new WaitForSecondsRealtime(3f);
				StopMusic();
				yield return new WaitForSecondsRealtime(3f);
				SceneManager.LoadScene(0);
				break;
			case 200:
				break;
			case 201:
				break;
			case 202:
				break;
			case 203:
				break;
			case 204:
				break;
			case 205:
				break;
			case 206:
				break;
			case 207:
				break;
			case 208:
				break;
			case 209:
				break;

		}

		yield return new WaitForEndOfFrame();
		st.CoroutineEnding();
	}

	private IEnumerator G1A3()
	{
		st.CoroutineBegining();

		switch(st.step)
		{
			case 0:
				SandInfoMessage("Вам удалось завR41H2 D8-15це <color=#6AEC49>Франчески</color>");
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

	private IEnumerator G1A4()
	{
		st.CoroutineBegining();

		switch(st.step)
		{
			case 0:
				SandInfoMessage("Ваши действия привели к большему разложению");
				Think("Вместо ответа Андрей натыкается на крохотную прорезь, прямо под Беларусью:");
				break;
			case 1:
				Think("Он останавливается. Буквально замирает, некультурно пялясь на плату, на которой нет никаких опознавательных знаков, кроме пары из минуса и плюса. ");
				break;
			case 2:
				Say("a", "А ведь у каждой детской херни должны быть батарейки.");
				break;
			case 3:
				PlaySound(3);
				Think("Он ухмыляется и ещё раз повторяет, едва не утыкаясь носом во Франческу, шепча ей на метафорическое ухо");
				break;
			case 4:
				PlaySound(4);
				Say("a", RichText("У каждой херни для детишек должна при себе быть батарейка!", Color.green));
				break;
			case 5:
				Think("Пара прохожих кидают на него брезгливые взгляды, в которых иногда читается и жалость — она куда отвратительное этой самой брезгливости. ");
				break;
			case 6:
				Think("Подведённые алым губы шепчут подружке что-то там про соли, а голубые глазки  прожигают дырку под кадыком. Девчушка в модных сапожках делает вид, что после душещипательных бесед с подружкой ей очень хочется диетической колы. ");
				break;
			case 7:
				Think("Андрей едва не оставляет рядышком с батарейками Франчески свой ноготь большого пальца — достаточно длинный, чтобы на сотую долю миллиметра войти ей в запретный отсек и застрять там.");
				break;
			case 8:
				Think("Это больно, пиздецки больно, и машина времени в приступе Андрюшиной ярости летит на пол.");
				break;
			case 9:
				StopMusic();
				PlaySound(1);
				Shake();
				Say("a", "Блять!!");
				break;
			case 10:
				Think("Выходит как-то смазано — и полёт следом на мраморный пол, и само междометие, и глухой удар коленями об плитку. ");
				break;
			case 11:
				PlayMusic(3);
				Think("Девчушка — хотя ей больше подходит быть «девочкой-пиздец» — там же и локоны, и бледная кожа, и красивая, желанная худоба в сорок килограмм. Не та, что героиновый шик, а та, что светится с обложек глянца. И глаза ещё карие: обжигают каждого, кто посмотрит. ");
				break;
			case 12:
				Think("И вот стоит она, в чёрном платьице от Луи, выуживая из клатча карточку, чтобы купить себе…");
				break;
			case 13:
				Think("Андрею похуй, что. Он поднимает Франческу и встаёт, тяжело опираясь на стену, продолжая колупать её пальцем, не обращая на девчонку-модель никакого внимания. ");
				break;
			case 14:
				Say("Девушка 1", "Пойдём уже, не он это… ");
				break;
			case 15:
				Think("Удивительное косноязычие для такой вот подружки. Подружка эта наклоняется ниже, чтобы Андрюша не дай бог не услышал.");
				break;
			case 16:
				Think("Шепчет, и сразу же дёргает за локоть, удивительно неизящно. В изящность тут играет только застывшая у автомата брюнетка — смотрит на Андрюшу в грязных джинсах — бледного, ковыряющегося в детской игрушке и не заметившего, как ебнулся об стену. ");
				break;
			case 17:
				Think("Брюнетка вцепляется в собственный клатч и инстинктивно отводит глаза. Старается занять себя чем-то и не слышать глухого, пробирающего до костей звука удара Андрюшиного затылка об плитку.");
				break;
			case 18:
				Say("Девушка 2", "Этот карточки не принимает.");
				break;
			case 19:
				Think("Говорит нарочито громко, перебивая свою подружку, чтобы пьяный на грани с психозом Сукачев на свой счёт не подумал. Это для Андрея прошла вечность, а для двух его фанаток — короткое мгновение наедине с обдолбанной звездой: того и гляди начнёт скулить, и обоссыт тебе обувь. ");
				break;
			case 20:
				Say("Девушка 1", "Ну пойдём другой поищем. Только побыстрее, а-то  регистрация скоро начнётся.");
				break;
			case 21:
				Say("Девушка 1", "Надеюсь, он не в Москву.");
				break;
			case 22:
				Say("Девушка 2", "Не начнётся. У нас ещё полчаса");
				break;
			case 23:
				Think("Брюнетка сама хватает подругу под локоть и, бросив последний разочарованно-жалостливый взгляд, уходит, растворяясь в дружеской болтовне. ");
				break;
			case 24:
				Think("Карие глаза перестают блестеть не от досады, а скорее от лёгкого, разочарования — остывший сэндвич расстроит её сильнее сторчавшегося Андрея. Сэндвичу и замену найти куда сложнее, чем Сукачеву. ");
				break;
			case 25:
				Think("А Сукачев наконец-то взирает на внутренности своей Франчески — батареек, разумеется на месте нет, но главное не это: его внимание привлекает нечто, приклеенное к задней стенке. На первый взгляд это деформированная дешёвая пластмасса. А на второй…");
				break;
			case 26:
				Think("Это приклеенная скотчем записка. ");
				break;
			case 27:
				Think("Такая крошечная, что Андрюшу ждут максимум два слова, а единственный способ уместить инструкцию к машине времени на этом огрызке…");
				break;
			case 28:
				Item(12);
				Think("Шифр! ");
				break;
			case 29:
				Think("Андрюша скалится так, что на сделанной в крысу фотке выходит просто отвратительно. ");
				break;
			case 30:
				Think("Да, всё это время стая малолетних фанаток любовно угарала с него, а он и не в курсе.");
				break;
			case 31:
				Think("Он поддевает скотч и аккуратненько отдирает бумажку от зелёной пластмассы. ");
				break;
			case 32:
				Think("Разворачивает, а там целый А6, абсолютно гладенький, ни единой складочки на нём нет, и бумага оказывается плотной, дорогой, близкой к тонкому картону. ");
				break;
			case 33:
				Think("И там:");
				break;
			case 34:
				Think("«"+RichText("22-18-1-15-25-6-19-12-1", Color.green)+" и их отличие от классической"+RichText("14-1-26-10-15-29 21-5-1-25-10", Color.green)+"»");
				break;
			case 35:
				Think("У "+RichText("14-1-26-10-15-29 21-5-1-25-10", Color.green)+" выбранная точка в пределах 10 лет от точки, в которой вы их активировали, запоминается программой, которая отнюдь не бесконечна, и зависит от объёма батареи. Расчетное время пребывания в выбранной точке зависит от объёма батареи, но не может превышать 12 часов, иначе вы рискуете её сломать и стереть себя из существования.");
				break;
			case 36:
				Think(RichText("22-18-1-15-25-6-19-12-1", Color.green)+" же:");
				break;
			case 37:
				Think("1.Черпает силу не из батарейки, а из "+RichText("9-6-13-7-15-16-4-16 19-16-13-15-24-1 — 1-19-20-6-18-16-10-5-1, 18-1-9-14-6-18-16-14 19-17-13-21-20-16-15", Color.green)+" обладающего "+RichText("18-1-9-21-14-16-14", Color.green));
				break;
			case 38:
				Think("2.Может переместить вас в любую выбранную точку. Но помните, что сила "+RichText("9-6-13-7-15-16-4-16 19-16-13-15-24-1", Color.green)+" находится за пределами человеческого понимания, и вы играете с огнём, для своей вселенной чуждым.");
				break;
			case 39:
				Think("Так что играйте с умом, и помните:");
				break;
			case 40:
				Think(RichText("22-18-1-15-25-6-19-12-1 18-1-9-21-14-15-1", Color.green)+"и "+RichText("14-1-26-10-15-29 21-5-1-25-10", Color.green)+" рядом с ней создают помехи");
				break;
			case 41:
				if(gm.Stats["Франческа"]>1)
					Think(RichText("P.S.S. A1Z26", Color.green));
				else
					Think("P.S. Разумна совсем не так, как ты думаешь.");
				break;
			case 42:
				st.CanSkip(false);
				gm.act.CanTap=false;
				SetAllButtons(false);
				StopMusic();
				Fade(10f, "...");
				yield return new WaitForSecondsRealtime(7f);
				SceneManager.LoadScene(0);
				break;
		}

		yield return new WaitForEndOfFrame();
		st.CoroutineEnding();
	}
}
