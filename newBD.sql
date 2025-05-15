-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Май 26 2024 г., 16:42
-- Версия сервера: 10.4.32-MariaDB
-- Версия PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `recipebookdb`
--

-- --------------------------------------------------------

--
-- Структура таблицы `favoriterecipes`
--

CREATE TABLE `favoriterecipes` (
  `UserId` int(11) NOT NULL,
  `RecipeId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Дамп данных таблицы `favoriterecipes`
--

INSERT INTO `favoriterecipes` (`UserId`, `RecipeId`) VALUES
(1, 1),
(1, 2),
(1, 9),
(7, 1),
(7, 78),
(7, 87),
(7, 90),
(7, 92),
(7, 104);

-- --------------------------------------------------------

--
-- Структура таблицы `ingredients`
--

CREATE TABLE `ingredients` (
  `Id` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `MeasurementUnit` varchar(255) DEFAULT NULL,
  `Calories` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Дамп данных таблицы `ingredients`
--

INSERT INTO `ingredients` (`Id`, `Name`, `MeasurementUnit`, `Calories`) VALUES
(1, 'Капуста', 'грам', 25),
(2, 'Морква', 'грам', 41),
(3, 'Буряк', 'грам', 43),
(4, 'Цибуля', 'грам', 40),
(5, 'Картопля', 'грам', 77),
(6, 'Брокколі', 'грам', 34),
(7, 'Квасоля', 'грам', 333),
(8, 'Рис', 'грам', 130),
(9, 'Яйця', 'штука', 70),
(10, 'Олія', 'грам', 884),
(11, 'Яйце', 'шт.', 70),
(12, 'Бекон', 'грам', 100),
(13, 'Брокколі', 'грам', 34),
(14, 'Томат', 'грам', 18),
(15, 'Картопля', 'грам', 77),
(16, 'Куряча грудка', 'грам', 165),
(17, 'Морква', 'грам', 41),
(18, 'Капуста', 'грам', 25),
(19, 'Сир', 'грам', 402),
(20, 'Банан', 'грам', 89),
(21, 'Йогурт', 'грам', 59),
(22, 'Рис', 'грам', 130),
(23, 'М\'ясо', 'грам', 250),
(24, 'Буряк', 'грам', 43),
(25, 'Масло', 'грам', 717),
(26, 'Борошно', 'грам', 364),
(27, 'Цукор', 'грам', 387),
(28, 'Кориця', 'грам', 247),
(29, 'Авокадо', 'грам', 160),
(30, 'Квасоля', 'грам', 333),
(31, 'Сир маскарпоне', 'грам', 435),
(32, 'Риба', 'грам', 206),
(33, 'Шоколад', 'грам', 546),
(34, 'Вершки', 'грам', 195),
(35, 'Баклажан', 'грам', 24),
(36, 'Зелень', 'грам', 22),
(37, 'Салатні листя', 'грам', 15),
(38, 'Ковбаса', 'грам', 300),
(39, 'Тунець', 'грам', 132),
(40, 'Яйце', 'шт.', 70),
(41, 'Бекон', 'грам', 100),
(42, 'Брокколі', 'грам', 34),
(43, 'Томат', 'грам', 18),
(44, 'Картопля', 'грам', 77),
(45, 'Куряча грудка', 'грам', 165),
(46, 'Морква', 'грам', 41),
(47, 'Капуста', 'грам', 25),
(48, 'Сир', 'грам', 402),
(49, 'Банан', 'грам', 89),
(50, 'Йогурт', 'грам', 59),
(51, 'Рис', 'грам', 130),
(52, 'М\'ясо', 'грам', 250),
(53, 'Буряк', 'грам', 43),
(54, 'Масло', 'грам', 717),
(55, 'Борошно', 'грам', 364),
(56, 'Цукор', 'грам', 387),
(57, 'Кориця', 'грам', 247),
(58, 'Авокадо', 'грам', 160),
(59, 'Квасоля', 'грам', 333),
(60, 'Сир маскарпоне', 'грам', 435),
(61, 'Риба', 'грам', 206),
(62, 'Шоколад', 'грам', 546),
(63, 'Вершки', 'грам', 195),
(64, 'Баклажан', 'грам', 24),
(65, 'Зелень', 'грам', 22),
(66, 'Салатні листя', 'грам', 15),
(67, 'Ковбаса', 'грам', 300),
(68, 'Тунець', 'грам', 132),
(69, 'Яйце', 'шт.', 70),
(70, 'Бекон', 'грам', 100),
(71, 'Брокколі', 'грам', 34),
(72, 'Томат', 'грам', 18),
(73, 'Картопля', 'грам', 77),
(74, 'Куряча грудка', 'грам', 165),
(75, 'Морква', 'грам', 41),
(76, 'Капуста', 'грам', 25),
(77, 'Сир', 'грам', 402),
(78, 'Банан', 'грам', 89),
(79, 'Йогурт', 'грам', 59),
(80, 'Рис', 'грам', 130),
(81, 'М\'ясо', 'грам', 250),
(82, 'Буряк', 'грам', 43),
(83, 'Масло', 'грам', 717),
(84, 'Борошно', 'грам', 364),
(85, 'Цукор', 'грам', 387),
(86, 'Кориця', 'грам', 247),
(87, 'Авокадо', 'грам', 160),
(88, 'Квасоля', 'грам', 333),
(89, 'Сир маскарпоне', 'грам', 435),
(90, 'Риба', 'грам', 206),
(91, 'Шоколад', 'грам', 546),
(92, 'Вершки', 'грам', 195),
(93, 'Баклажан', 'грам', 24),
(94, 'Зелень', 'грам', 22),
(95, 'Салатні листя', 'грам', 15),
(96, 'Ковбаса', 'грам', 300),
(97, 'Тунець', 'грам', 132);

-- --------------------------------------------------------

--
-- Структура таблицы `recipeingredients`
--

CREATE TABLE `recipeingredients` (
  `RecipeId` int(11) NOT NULL,
  `IngredientId` int(11) NOT NULL,
  `Quantity` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Дамп данных таблицы `recipeingredients`
--

INSERT INTO `recipeingredients` (`RecipeId`, `IngredientId`, `Quantity`) VALUES
(1, 1, '200 грам'),
(1, 2, '50 грам'),
(1, 10, '30 мл'),
(2, 1, '300 грам'),
(2, 2, '100 грам'),
(2, 3, '100 грам'),
(2, 4, '100 грам'),
(2, 5, '200 грам'),
(2, 23, '300 грам'),
(3, 1, '300 грам'),
(3, 2, '100 грам'),
(3, 4, '100 грам'),
(4, 1, '200 грам'),
(4, 2, '100 грам'),
(4, 5, '200 грам'),
(5, 5, '200 грам'),
(5, 6, '150 грам'),
(6, 1, '300 грам'),
(6, 4, '100 грам'),
(6, 11, '3 штуки'),
(7, 1, '200 грам'),
(7, 2, '100 грам'),
(7, 3, '100 грам'),
(8, 1, '300 грам'),
(8, 7, '200 грам'),
(9, 1, '300 грам'),
(9, 2, '100 грам'),
(9, 22, '200 грам'),
(10, 1, '150 грам'),
(10, 11, '2 штуки'),
(78, 9, '1 штука'),
(78, 12, '100 грам'),
(79, 5, '100 грам'),
(79, 7, '150 грам'),
(80, 12, '100 грам'),
(80, 22, '200 грам'),
(81, 2, '50 грам'),
(81, 11, '2 штуки'),
(81, 13, '50 грам'),
(82, 16, '150 грам'),
(82, 19, '50 грам'),
(83, 13, '50 грам'),
(83, 14, '200 грам'),
(84, 16, '200 грам'),
(84, 22, '100 грам'),
(85, 5, '100 грам'),
(85, 20, '50 грам'),
(86, 9, '2 штуки'),
(86, 17, '50 грам'),
(86, 24, '50 грам'),
(87, 5, '200 грам'),
(87, 19, '100 грам'),
(88, 20, '1 штука'),
(88, 21, '100 грам'),
(89, 22, '200 грам'),
(89, 23, '100 грам'),
(90, 1, '100 грам'),
(90, 2, '50 грам'),
(90, 14, '50 грам'),
(91, 11, '2 штуки'),
(91, 19, '100 грам'),
(92, 19, '200 грам'),
(93, 2, '50 грам'),
(93, 4, '50 грам'),
(93, 5, '100 грам'),
(93, 12, '50 грам'),
(94, 5, '100 грам'),
(94, 10, '50 грам'),
(95, 19, '200 грам'),
(95, 24, '50 грам'),
(96, 14, '50 грам'),
(96, 22, '100 грам'),
(97, 17, '50 грам'),
(97, 19, '200 грам'),
(98, 16, '100 грам'),
(98, 21, '50 грам'),
(99, 4, '100 грам'),
(99, 23, '200 грам'),
(100, 11, '2 штуки'),
(100, 19, '50 грам'),
(101, 22, '200 грам'),
(101, 23, '100 грам'),
(102, 16, '100 грам'),
(102, 21, '50 грам'),
(103, 14, '200 грам'),
(103, 19, '50 грам'),
(104, 5, '100 грам'),
(104, 16, '200 грам'),
(105, 5, '200 грам'),
(105, 23, '100 грам'),
(106, 19, '50 грам'),
(106, 24, '100 грам'),
(107, 5, '200 грам'),
(107, 23, '100 грам');

-- --------------------------------------------------------

--
-- Структура таблицы `recipes`
--

CREATE TABLE `recipes` (
  `Id` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Description` text DEFAULT NULL,
  `CookingTime` int(11) DEFAULT NULL,
  `Category` varchar(255) DEFAULT NULL,
  `TotalCalories` int(11) DEFAULT NULL,
  `CookingInstructions` text DEFAULT NULL,
  `VideoUrl` varchar(255) DEFAULT NULL,
  `ImageUrl` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Дамп данных таблицы `recipes`
--

INSERT INTO `recipes` (`Id`, `Name`, `Description`, `CookingTime`, `Category`, `TotalCalories`, `CookingInstructions`, `VideoUrl`, `ImageUrl`) VALUES
(1, 'Капустяний салат', 'Легкий капустяний салат з морквою та зеленню', 15, 'Салати', 150, 'Наріжте капусту та моркву, додайте зелень. Заправте олією.', 'https://youtu.be/PgKaxVr2ZoA', 'https://poradnuk.com/wp-content/uploads/2017/11/9a6104b1bd5b3d091e2f862a26221413.jpg'),
(2, 'Борщ', 'Традиційний український борщ з буряком та капустою', 120, 'Супи', 300, 'Варіть м\'ясо, додайте буряк, капусту та інші овочі.', 'https://youtu.be/qkTlcfCw7jQ', 'https://images.unian.net/photos/2020_04/thumb_files/800_0_1588081977-7108.jpg?0.533115173094685'),
(3, 'Тушкована капуста', 'Тушкована капуста з морквою та цибулею', 60, 'Гарячі страви', 200, 'Тушкуйте капусту з морквою та цибулею.', 'https://youtu.be/6cR8q06jaSo', 'https://www.rbc.ua/static/img/_/k/_kapusta_freepik_com_4_1200x675.jpg'),
(4, 'Овочевий рагу', 'Рагу з капустою, картоплею та морквою', 45, 'Гарячі страви', 250, 'Тушкуйте всі овочі разом.', 'https://youtu.be/qKU_qXY3c2Y', 'https://i.obozrevatel.com/food/recipemain/2019/1/9/156.jpg'),
(5, 'Суп з брокколі', 'Суп з брокколі та картоплею', 30, 'Супи', 180, 'Варіть брокколі та картоплю.', 'https://youtu.be/5dhX_rDGQ7w', 'https://shuba.life/static/content/thumbs/1905x884/d/d9/w6s7an---c1905x884x50px50p-up--2b34d2441a9aeb02ea98bfd5b85bbd9d.jpg'),
(6, 'Капустяний пиріг', 'Пиріг з капустою та яйцями', 90, 'Випічка', 400, 'Зробіть тісто, додайте начинку з капусти та яєць.', 'https://youtu.be/noyjbNqoFtU', 'https://img.tsn.ua/cached/236/tsn-90ef87392779da7417a975ee734335dc/thumbs/1200x630/4a/e9/e849c511ee4455573090094ca208e94a.jpeg'),
(7, 'Салат \"Щітка\"', 'Салат з капусти, моркви та буряка', 20, 'Салати', 120, 'Наріжте всі овочі та перемішайте.', 'https://youtu.be/C98PQ-B-YSg', 'https://health.fakty.com.ua/wp-content/uploads/sites/2/2022/05/08/salat-shchitka-620x349.jpg'),
(8, 'Суп з капустою та квасолею', 'Суп з капустою та квасолею', 60, 'Супи', 220, 'Варіть капусту та квасолю разом.', 'https://youtu.be/o9l0CqGpVyE', 'https://i.ytimg.com/vi/IgKi96RgkFI/maxresdefault.jpg'),
(9, 'Плов з капустою', 'Плов з капустою та морквою', 90, 'Гарячі страви', 350, 'Готуйте рис з капустою та морквою.', 'https://youtu.be/k0xSNmPbBtQ', 'https://i.ytimg.com/vi/fy2mYiL12cE/hq720.jpg?sqp=-oaymwEhCK4FEIIDSFryq4qpAxMIARUAAAAAGAElAADIQj0AgKJD&rs=AOn4CLDTA5Ru8q5Gl1EBYwF7oUSJN-t7ng'),
(10, 'Омлет з капустою', 'Омлет з капустою та зеленню', 15, 'Сніданок', 180, 'Збийте яйця, додайте капусту та зелень. Смажте.', 'https://youtu.be/m3x7alDabAw', 'https://shuba.life/static/content/thumbs/1905x884/0/e8/q3ur2v---c1905x884x50px50p-up--face6c6ae045aed81d066119a1284e80.jpg'),
(78, 'Сніданковий бургер', 'Смачний бургер з яєчнею і беконом', 20, 'Сніданок', 500, '1. Посмажте бекон і яйце. 2. Зберіть бургер з інгредієнтів.', 'https://youtu.be/X_iRQM-8EAM', 'https://static.nv.ua/shared/system/MediaPhoto/images/000/488/223/original/b7c600d7b72b42e7e1b3b9dfd0b36822.png'),
(79, 'Гороховий суп', 'Легкий суп з брокколі і картоплею', 30, 'Супи', 200, '1. Відваріть брокколі і картоплю. 2. Змішайте інгредієнти.', 'https://youtu.be/nZKQaiAVXMI', 'https://myastoriya.com.ua/upload/medialibrary/4df/4dfebfed32b2ef3e982395a16e7ab9af.jpg'),
(80, 'Паста Карбонара', 'Класична італійська паста з беконом і сиром', 25, 'Гарячі страви', 600, '1. Відваріть пасту. 2. Додайте соус з беконом і сиром.', 'https://youtu.be/mT8B9fE_vdg', 'https://smachno.ua/wp-content/uploads/2012/10/11/Depositphotos_76101093_m-2015.jpg'),
(81, 'Омлет з овочами', 'Ситний омлет з різноманітними овочами', 15, 'Сніданок', 300, '1. Посмажте омлет з овочами.', 'https://youtu.be/a1-4HMc5Q00', 'https://img.tsn.ua/cached/637/tsn-671b840e81dae5015bc4c6345e63d1d0/thumbs/428x268/38/3e/3b425e0e930b187d5c782c8cf1623e38.jpeg'),
(82, 'Салат Цезар', 'Популярний салат з куркою і сиром', 20, 'Салати', 400, '1. Змішайте курку, сир і салатні листя з соусом.', 'https://youtu.be/jP5NjKfujEw', 'https://images.unian.net/photos/2019_02/thumb_files/1000_545_1551364909-4775.jpg'),
(83, 'Томатний суп', 'Легкий томатний суп з базиліком', 35, 'Супи', 150, '1. Відваріть томати і зробіть суп з базиліком.', 'https://youtu.be/GRHn1pwYtvU', 'https://images.unian.net/photos/2021_02/thumb_files/800_0_1612272377-7819.jpg?0.21557517148618088'),
(84, 'Куряча грудка з рисом', 'Здорова страва з курячою грудкою і рисом', 40, 'Гарячі страви', 450, '1. Запечіть курячу грудку і відваріть рис.', 'https://youtu.be/UnW9JuzTAjM', 'https://cesmak.info/uploads/posts/2018-05/15263843731thumb-840x440.jpg'),
(85, 'Щавлевий борщик', 'Традиційний український суп з буряком', 60, 'Супи', 350, '1. Відваріть буряк і інші овочі, додайте м\'ясо.', 'https://youtu.be/opuvUUHIeTA', 'https://img.tsn.ua/cached/917/tsn-28424b79aaed18622b3ebc9e28e9f35e/thumbs/1116x628/c5/ba/09fb3db200b3070942c8c9f9e2b6bac5.jpeg'),
(86, 'Панкейки', 'Смачні американські млинці', 20, 'Сніданок', 300, '1. Змішайте тісто і посмажте млинці.', 'https://youtu.be/mTcqjo03gYI', 'https://images.unian.net/photos/2020_05/thumb_files/800_0_1588949166-1080.jpg?0.9418835851163794'),
(87, 'Лазанья', 'Італійська лазанья з м\'ясом і сиром', 50, 'Гарячі страви', 700, '1. Приготуйте соус болоньєзе і бешамель. 2. Зберіть лазанью.', 'https://youtu.be/C6aB7JghUcs', 'https://i.obozrevatel.com/food/recipemain/2022/1/24/2017foodfreshlasagnawithredlarge.jpg?size=636x424'),
(88, 'Смузі з бананом', 'Здоровий смузі з бананом і йогуртом', 10, 'Сніданок', 150, '1. Змішайте банан і йогурт у блендері.', 'https://youtu.be/9YHI_X9z7Gk', 'https://golden-flamingo.com.ua/wp-content/uploads/2023/06/banana-smoothie-recipes-1.jpg'),
(89, 'Плов', 'Ситний плов з м\'ясом і спеціями', 60, 'Гарячі страви', 500, '1. Обсмажте м\'ясо і овочі, додайте рис і спеції.', 'https://youtu.be/M6T2nlUIGoA', 'https://cipollino.ua/content/uploads/images/vse-tonkosty-y-sekrety-pryhotovlenyia-plova-cipollino.ua.jpg'),
(90, 'Рататуй', 'Французька овочева страва', 45, 'Гарячі страви', 250, '1. Запечіть різноманітні овочі.', 'https://youtu.be/JQP1W2fX0Gs', 'https://ukranews.com/upload/media/2021/03/16/60511e793978a-ratatuy-iz-baklazhanov.jpg'),
(91, 'Млинці з сиром', 'Солодкі млинці з сирною начинкою', 30, 'Десерти', 400, '1. Посмажте млинці і додайте сирну начинку.', 'https://youtu.be/Zq6l0mQzmyc', 'https://img.cookorama.net/uploads/images/00/01/32/2016/04/03/533119_780x.jpg'),
(92, 'Сирники', 'Традиційні українські сирники з медом', 25, 'Сніданок', 350, '1. Зробіть тісто з сиру і смажте сирники.', 'https://youtu.be/EiqJwjxucgY', 'https://fayni-recepty.com.ua/wp-content/uploads/2020/01/syrnyky-retsepty-1024x683.jpg'),
(93, 'Салат Олів\'є', 'Популярний салат з овочами і ковбасою', 30, 'Салати', 300, '1. Змішайте відварені овочі з ковбасою і майонезом.', 'https://youtu.be/O8wxBQu1JOk', 'https://fayni-recepty.com.ua/wp-content/uploads/2020/08/olivie.jpg'),
(94, 'Запечена риба', 'Риба запечена з лимоном і травами', 35, 'Гарячі страви', 250, '1. Запечіть рибу з лимоном і травами.', 'https://youtu.be/VsxkysCljyA', 'https://klopotenko.com/wp-content/uploads/2018/02/Zapechenyi-karp-z-lymonom-i-oregano_siteWebUkr.jpg?v=1588529932'),
(95, 'Тірамісу', 'Італійський десерт з кавою і сиром маскарпоне', 40, 'Десерти', 500, '1. Приготуйте крем з маскарпоне і збирайте десерт з кавою.', 'https://youtu.be/ZO8unSvWMC8', 'https://ukr.media/static/ba/aimg/3/6/7/367793_1.jpg'),
(96, 'Гречана каша', 'Гречана каша з овочами', 25, 'Гарячі страви', 200, '1. Відваріть гречку і додайте обсмажені овочі.', 'https://youtu.be/-M2f7l-6d18', 'https://i.obozrevatel.com/food/recipemain/2019/3/9/6.jpg?size=636x424'),
(97, 'Яблучний пиріг', 'Смачний яблучний пиріг з корицею', 50, 'Десерти', 400, '1. Приготуйте тісто і запечіть пиріг з яблуками.', 'https://youtu.be/YcCMi4tX1YQ', 'https://lasunka.com/s152-3.jpg'),
(98, 'Салат з мідіями', 'Свіжий салат з креветками і авокадо', 20, 'Салати', 300, '1. Змішайте креветки, авокадо і салатні листя з соусом.', 'https://youtu.be/kvuyf1eFXrc', 'https://u-news.com.ua/uploads/posts/2022-02/1643886537_2.webp'),
(99, 'Гуляш', 'Угорський м\'ясний гуляш з овочами', 60, 'Гарячі страви', 400, '1. Обсмажте м\'ясо і овочі, додайте спеції.', 'https://youtu.be/IBCTvXGtdVI', 'https://img.tsn.ua/cached/816/tsn-d7721072f5f1787fa1f16a6df613a75f/thumbs/428x268/33/2e/cf701e68da7404374d8904877ff12e33.jpeg'),
(100, 'Фрітата', 'Італійський омлет з овочами і сиром', 30, 'Сніданок', 300, '1. Посмажте овочі і залийте яйцями, додайте сир.', 'https://youtu.be/19ZEBBvssFM', 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQMyIB2t_W9PhNKzmgm718luzwo-rVXbKiJADj7IiT3Jg&s'),
(101, 'Суші', 'Традиційні японські суші з рибою і рисом', 60, 'Гарячі страви', 350, '1. Приготуйте рис і зберіть суші з рибою.', 'https://youtu.be/If0uN9P2EoQ', 'https://images.unian.net/photos/2020_12/thumb_files/1000_545_1607415497-3934.jpg?1'),
(102, 'Салат з тунцем', 'Легкий салат з тунцем і овочами', 20, 'Салати', 200, '1. Змішайте тунець, овочі і салатні листя.', 'https://youtu.be/K3a_Uwr7ypA', 'https://klopotenko.com/wp-content/uploads/2023/12/salat-z-tuntsem-i-yaytsyamy-img-1000x600.jpg?v=1701419239'),
(103, 'Баклажани по-італійськи', 'Запечені баклажани з сиром і томатами', 40, 'Гарячі страви', 250, '1. Запечіть баклажани з сиром і томатами.', 'https://youtu.be/EG4mPNkXIic', 'https://znaj.ua/crops/62f8b6/620x0/1/0/2023/09/09/k0V2bLb9V7o10JOy5H3gG2Da5pdgP1FE7pc41owe.jpg'),
(104, 'Курячий суп', 'Легкий курячий суп з овочами', 30, 'Супи', 150, '1. Відваріть курку і овочі.', 'https://youtu.be/vZybCtFrmP4', 'https://ukr.media/static/ba/aimg/4/0/0/400409_1.jpg'),
(105, 'Печеня з картоплею', 'Запечена картопля з м\'ясом і овочами', 60, 'Гарячі страви', 500, '1. Запечіть картоплю з м\'ясом і овочами.', 'https://youtu.be/j9W_dxX7DR0', 'https://images.unian.net/photos/2020_06/thumb_files/1000_545_1592566060-3432.jpg'),
(106, 'Шоколадний фондан', 'Смачний десерт з шоколадом і вершками', 20, 'Десерти', 300, '1. Змішайте шоколад і вершки, охолодіть.', 'https://youtu.be/wHvyaoqATjo', 'https://klopotenko.com/wp-content/uploads/2023/12/chocolate-lava-cake_siteweb-img-1000x600.jpg?v=1702641814'),
(107, 'Запечена картопля з начинкою', 'Запечені овочі з прянощами', 40, 'Гарячі страви', 200, '1. Запечіть овочі з прянощами.', 'https://youtu.be/HiIWtEDgieM', 'https://volyngid.com/wp-content/uploads/taku-vy-shhe-ne-yily-zapechena-kartoplya-v-duhovczi-z-nachynkoyu-i-bez.jpg');

-- --------------------------------------------------------

--
-- Структура таблицы `reviews`
--

CREATE TABLE `reviews` (
  `Id` int(11) NOT NULL,
  `UserId` int(11) DEFAULT NULL,
  `RecipeId` int(11) DEFAULT NULL,
  `Rating` int(11) DEFAULT NULL,
  `Comment` text DEFAULT NULL,
  `Date` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Дамп данных таблицы `reviews`
--

INSERT INTO `reviews` (`Id`, `UserId`, `RecipeId`, `Rating`, `Comment`, `Date`) VALUES
(2, 1, 1, 5, 'Чудовий рецепт!', '2024-05-16 13:42:12'),
(3, 2, 1, 4, 'Дуже смачно, але потрібно трохи більше спецій.', '2024-05-16 13:42:12'),
(4, 3, 2, 3, 'Не дуже сподобалося, потрібно більше солі.', '2024-05-16 13:42:12'),
(5, 4, 2, 5, 'Прекрасний рецепт, рекомендую всім!', '2024-05-16 13:42:12'),
(6, 1, 9, 2, 'норм', '2024-05-16 13:46:50'),
(8, 7, 92, 2, 'не дуже', '2024-05-22 23:17:51');

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `Id` int(11) NOT NULL,
  `FirstName` varchar(255) DEFAULT NULL,
  `LastName` varchar(255) DEFAULT NULL,
  `Email` varchar(255) NOT NULL,
  `Username` varchar(255) DEFAULT NULL,
  `Password` varchar(255) DEFAULT NULL,
  `RegistrationDate` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`Id`, `FirstName`, `LastName`, `Email`, `Username`, `Password`, `RegistrationDate`) VALUES
(1, 'Іван', 'Іванов', 'ivanov@example.com', 'ivan', 'password1', '2024-05-16 13:42:12'),
(2, 'Петро', 'Петренко', 'petrenko@example.com', 'petro', 'password2', '2024-05-16 13:42:12'),
(3, 'Ольга', 'Ольхова', 'olkova@example.com', 'olga', 'password3', '2024-05-16 13:42:12'),
(4, 'Марія', 'Марченко', 'marchenko@example.com', 'maria', 'password4', '2024-05-16 13:42:12'),
(5, 'Андрій', 'Андрієнко', 'andriyenko@example.com', 'andriy', 'password5', '2024-05-16 13:42:12'),
(7, '1', 'Андрієнко', '1@example.com', '1', '1', '2024-05-16 13:42:12'),
(8, NULL, NULL, '', '2', '2', NULL);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `favoriterecipes`
--
ALTER TABLE `favoriterecipes`
  ADD PRIMARY KEY (`UserId`,`RecipeId`),
  ADD KEY `RecipeId` (`RecipeId`);

--
-- Индексы таблицы `ingredients`
--
ALTER TABLE `ingredients`
  ADD PRIMARY KEY (`Id`);

--
-- Индексы таблицы `recipeingredients`
--
ALTER TABLE `recipeingredients`
  ADD PRIMARY KEY (`RecipeId`,`IngredientId`),
  ADD KEY `IngredientId` (`IngredientId`);

--
-- Индексы таблицы `recipes`
--
ALTER TABLE `recipes`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `idx_unique_recipe_name` (`Name`);

--
-- Индексы таблицы `reviews`
--
ALTER TABLE `reviews`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `UserId` (`UserId`),
  ADD KEY `RecipeId` (`RecipeId`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `Email` (`Email`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `ingredients`
--
ALTER TABLE `ingredients`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- AUTO_INCREMENT для таблицы `recipes`
--
ALTER TABLE `recipes`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=123;

--
-- AUTO_INCREMENT для таблицы `reviews`
--
ALTER TABLE `reviews`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `favoriterecipes`
--
ALTER TABLE `favoriterecipes`
  ADD CONSTRAINT `favoriterecipes_ibfk_1` FOREIGN KEY (`UserId`) REFERENCES `users` (`Id`),
  ADD CONSTRAINT `favoriterecipes_ibfk_2` FOREIGN KEY (`RecipeId`) REFERENCES `recipes` (`Id`);

--
-- Ограничения внешнего ключа таблицы `recipeingredients`
--
ALTER TABLE `recipeingredients`
  ADD CONSTRAINT `recipeingredients_ibfk_1` FOREIGN KEY (`RecipeId`) REFERENCES `recipes` (`Id`),
  ADD CONSTRAINT `recipeingredients_ibfk_2` FOREIGN KEY (`IngredientId`) REFERENCES `ingredients` (`Id`);

--
-- Ограничения внешнего ключа таблицы `reviews`
--
ALTER TABLE `reviews`
  ADD CONSTRAINT `reviews_ibfk_1` FOREIGN KEY (`UserId`) REFERENCES `users` (`Id`),
  ADD CONSTRAINT `reviews_ibfk_2` FOREIGN KEY (`RecipeId`) REFERENCES `recipes` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
