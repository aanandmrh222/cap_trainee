| Category                | Regex        | Meaning                    | Example String | Matches           |      |       |
| ----------------------- | ------------ | -------------------------- | -------------- | ----------------- | ---- | ----- |
| **Digits**              | `\d`         | Any digit (0–9)            | `A1B2`         | `1`, `2`          |      |       |
|                         | `\d+`        | One or more digits         | `A123B`        | `123`             |      |       |
|                         | `\d*`        | Zero or more digits        | `ABC`          | `""` (empty)      |      |       |
|                         | `\D`         | Any non-digit              | `10A20`        | `A`               |      |       |
|                         | `\D+`        | One or more non-digits     | `10ABC20`      | `ABC`             |      |       |
| **Word**                | `\w`         | Letter, digit, underscore  | `A_1`          | `A`, `_`, `1`     |      |       |
|                         | `\w+`        | One or more word chars     | `Hi_123`       | `Hi_123`          |      |       |
|                         | `\W`         | Non-word character         | `Hi@123`       | `@`               |      |       |
|                         | `\W+`        | One or more non-word chars | `Hi@@123`      | `@@`              |      |       |
| **Whitespace**          | `\s`         | Space, tab, newline        | `A B`          | space             |      |       |
|                         | `\s+`        | One or more whitespaces    | `A   B`        | `"   "`           |      |       |
|                         | `\S`         | Non-whitespace             | `A B`          | `A`, `B`          |      |       |
|                         | `\S+`        | One or more non-spaces     | `A B C`        | `A`, `B`, `C`     |      |       |
| **Anchors**             | `^`          | Start of string            | `^Hi`          | Matches `Hi`      |      |       |
|                         | `$`          | End of string              | `Hi$`          | Matches `Hi`      |      |       |
|                         | `^Hi$`       | Exact match                | `Hi`           | `Hi`              |      |       |
| **Quantifiers**         | `*`          | 0 or more                  | `ab*`          | `a`, `ab`, `abb`  |      |       |
|                         | `+`          | 1 or more                  | `ab+`          | `ab`, `abb`       |      |       |
|                         | `?`          | 0 or 1                     | `colou?r`      | `color`, `colour` |      |       |
|                         | `{n}`        | Exactly n times            | `\d{3}`        | `123`             |      |       |
|                         | `{n,}`       | At least n                 | `\d{2,}`       | `12`, `123`       |      |       |
|                         | `{n,m}`      | Between n & m              | `\d{2,4}`      | `12`, `1234`      |      |       |
| **Character Set**       | `[abc]`      | a or b or c                | `cat`          | `c`, `a`          |      |       |
|                         | `[a-z]`      | lowercase letters          | `Abc`          | `b`, `c`          |      |       |
|                         | `[0-9]`      | digits                     | `A1B2`         | `1`, `2`          |      |       |
|                         | `[^0-9]`     | NOT digits                 | `A1B`          | `A`, `B`          |      |       |
| **Alternation**         | `            | `                          | OR             | `cat              | dog` | `dog` |
| **Grouping**            | `( )`        | Group patterns             | `(ab)+`        | `abab`            |      |       |
| **Named Group**         | `(?<id>\d+)` | Named capture              | `ID:123`       | `123`             |      |       |
| **Any Char**            | `.`          | Any char except newline    | `A@1`          | `A`, `@`, `1`     |      |       |
| **Escape**              | `\.`         | Literal dot                | `a.b`          | `.`               |      |       |
| **Lookahead**           | `\d(?=px)`   | Digit before `px`          | `10px`         | `0`               |      |       |
| **Negative Lookahead**  | `\d(?!px)`   | Digit NOT before `px`      | `10cm`         | `1`, `0`          |      |       |
| **Lookbehind**          | `(?<=₹)\d+`  | After ₹                    | `₹500`         | `500`             |      |       |
| **Negative Lookbehind** | `(?<!₹)\d+`  | Not after ₹                | `500`          | `500`             |      |       |
