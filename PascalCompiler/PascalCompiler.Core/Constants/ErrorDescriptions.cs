﻿using System.Collections.Generic;

namespace PascalCompiler.Core.Constants
{
    public static class ErrorDescriptions
    {
        private static Dictionary<int, string> _descriptions = new Dictionary<int, string>
        {
            [0] = "Неправильный способ использования идентификатора",
            [1] = "ошибка в простом типе",
            [2] = "должно идти имя",
            [3] = "должно быть служебное слово PROGRAM",
            [4] = "должен идти символ  ')'",
            [5] = "должен идти символ  ':'",
            [6] = "запрещенный символ",
            [7] = "ошибка в списке параметров",
            [8] = "должно идти  OF",
            [9] = "должен идти символ  '('",
            [10] = "ошибка в типе",
            [11] = "должен идти символ  '['",
            [12] = "должен идти символ  ']'",
            [13] = "должно идти слово  END",
            [14] = "должен идти символ  ';'",
            [15] = "должно идти целое",
            [16] = "должен идти символ  '='",
            [17] = "должно идти слово  BEGIN",
            [18] = "ошибка в разделе описаний",
            [19] = "ошибка в списке полей",
            [20] = "должен идти символ  ','",
            [21] = "ошибка в переменной",
            [22] = "ошибка в разделе операторов",
            [23] = "ошибка в выражении",
            [34] = "должно идти слово TYPE",
            [50] = "ошибка в константе",
            [51] = "должен идти символ  ':='",
            [52] = "должно идти слово  THEN",
            [53] = "должно идти слово  UNTIL",
            [54] = "должно идти слово  DO",
            [55] = "должно идти слово  TO  или  DOWNTO",
            [56] = "должно идти слово  IF",
            [61] = "должен идти символ  '.'",
            [74] = "должен идти символ  '..'",
            [75] = "ошибка в символьной константе",
            [76] = "слишком длинная строковая константа",
            [86] = "комментарий не закрыт",
            [85] = "комментарий не открыт",
            [83] = "Должна идти символьная константа",
            [100] = "использование имени не соответствует описанию",
            [101] = "имя описано повторно",
            [102] = "нижняя граница превосходит верхнюю",
            [103] = "Имя не принадлежит соответствующему классу",
            [104] = "имя не описано",
            [105] = "недопустимое рекурсивное определение",
            [108] = "файл здесь использовать нельзя",
            [109] = "тип не должен быть  REAL",
            [111] = "несовместимость с типом дискриминанта",
            [112] = "недопустимый ограниченный тип",
            [114] = "тип основания не должен быть  REAL  или  INTEGER",
            [115] = "файл должен быть текстовым",
            [116] = "ошибка в типе параметра стандартной процедуры",
            [117] = "неподходящее опережающее описание",
            [118] = "недопустимый тип пpизнака ваpиантной части записи",
            [119] = "опережающее описание: повторение списка параметров не допускается",
            [120] = "тип результата функции должен быть скалярным, ссылочным или ограниченным",
            [121] = "параметр-значение не может быть файлом",
            [122] = "опережающее описание функции: повторять тип результата нельзя",
            [123] = "в описании функции пропущен тип результата",
            [124] = "F-формат только для  REAL",
            [125] = "ошибка в типе параметра стандартной функции",
            [126] = "число параметров не согласуется с описанием",
            [127] = "недопустимая подстановка параметров",
            [128] = "тип результата функции не соответствует описанию",
            [130] = "выражение не относится к множественному типу",
            [135] = "тип операнда должен быть  BOOLEAN",
            [137] = "недопустимые типы элементов множества",
            [138] = "переменная не есть массив",
            [139] = "тип индекса не соответствует описанию",
            [140] = "переменная не есть запись",
            [141] = "переменная должна быть файлом или ссылкой",
            [142] = "недопустимая подстановка параметров",
            [143] = "недопустимый тип параметра цикла",
            [144] = "недопустимый тип выражения",
            [145] = "конфликт типов",
            [147] = "тип метки не совпадает с типом выбирающего выражения",
            [149] = "тип индекса не может быть  REAL  или  INTEGER",
            [152] = "в этой записи нет такого поля",
            [156] = "метка варианта определяется несколько раз",
            [165] = "метка определяется несколько раз",
            [166] = "метка описывается несколько раз",
            [167] = "неописанная метка",
            [168] = "неопределенная метка",
            [169] = "ошибка в основании множества  ( базовом типе )",
            [170] = "тип не может быть упакован",
            [177] = "здесь не допускается присваивание имени функции",
            [182] = "типы не совместны",
            [183] = "запрещенная в данном контексте операция",
            [184] = "элемент этого типа не может иметь знак",
            [186] = "несоответствие типов для операции отношения",
            [189] = "конфликт типов параметров",
            [190] = "повторное опережающее описание",
            [191] = "ошибка в конструкторе множества",
            [193] = "лишний индекс для доступа к элементу массива",
            [194] = "указано слишком мало индексов для доступа к злементу массива",
            [195] = "выбирающая константа вне границ описанного диапазона",
            [196] = "недопустимый тип выбирающей константы",
            [197] = "параметры процедуры(функции),являющейся параметром, д.б. пар.-значениями",
            [198] = "несоответствие количества параметров параметра-процедуры(функции)",
            [199] = "несоответствие типов параметров параметра-процедуры(функции)",
            [200] = "тип парамера-функции не соответствует описанию",
            [201] = "ошибка в вещественной константе: должна идти цифра",
            [203] = "целая константа превышает предел",
            [206] = "слишком маленькая вещественная константа",
            [207] = "слишком большая вещественная константа",
            [208] = "недопустимые типы операндов в операции IN",
            [209] = "вторым операндом IN должно быть множество",
            [210] = "операнды AND, NOT, OR должны быть булевыми",
            [211] = "недопустимые типы операндов в операции + или -",
            [212] = "операнды DIV и MOD должны быть целыми",
            [213] = "недопустимые типы операндов в операции *",
            [214] = "недопустимые типы операндов в операции /",
            [215] = "первым операндом IN должно быть выражение базового типа множества",
            [216] = "опережающее описание есть, полного нет",
            [305] = "индексное значение выходит за границы",
            [306] = "присваиваемое значение выходит за границы",
            [307] = "выражение для элемента множества выходит за пределы",
            [308] = "выражение выходит за допустимые пределы",
            [309] = "должно идти слово EXPORT",
            [310] = "должно идти слово IMPORT",
            [311] = "должно идти слово INTERFACE",
            [312] = "должно идти слово IMPLEMENTATION",
            [313] = "должно идти слово MODULE",
            [314] = "слишком много меток",
            [322] = "Странный оператор",
            [323] = "Плохие константы в ограниченном типе",
            [324] = "Небывает такого типа",
            [325] = "Неправильный вызов процедуры",
            [326] = "Слишком мало параметров",
            [327] = "Слишком много параметров",
            [328] = "Несоответствие типов",
            [329] = "Слишком много индексов",
            [330] = "Слишком мало индексов",
            [331] = "Должен идти тип",
            [332] = "Переменная не является массивом",
        };

        public static string Get(int errorCode) => _descriptions[errorCode];
    }
}
