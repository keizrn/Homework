<?php
$firstname = "Наталья";
$lastname = "Кейзер";
$occupation = "Аналитик Big Data";
$city = "Москва";
$country = "Россия";
$email = "BulavaNA@yandex.ru";
$phone = "+7 906 052 2702";

$skills = [
    ['name' => 'MS Excel', 'percent' => 90,
    ],
    ['name' => 'Python', 'percent' => 70,
    ],
    ['name' => 'Математика', 'percent' => 85,
    ],
    ['name' => 'Big Data', 'percent' => 45,
    ],
];

$languages = [
    ['name' => 'Английский', 'percent' => 100,
    ],
    ['name' => 'Французский', 'percent' => 30,
    ],
];

$jobExperience = [
    [
        'title' => 'Финансовый и административный менеджер',
        'company' => 'ООО "Лаборатуар Экспансьянс Рюси" (Mustela trademark)',
        'city' => 'Москва',
        'website' => 'www.mustela.ru',
        'datestart' => '06.2016',
        'datefinish' => '',
        'experience' => '- Подготовка и анализ годового бюджета компании
        - Формирование квартальных консолидированных отчетов для головного офиса (факт) - P&L, Balance Sheet, Cash Flow.
        - Участие в нескольких циклах бюджетирования (план)
        - Участие в годовом и промежуточном аудите
        - обеспечение работы компании с юридической, финансовой, бухгалтерской, административной, логистической, ИТ сторон. 2 прямых подчиненных, несколько компаний-подрядчиков.',
        'achievements' => '- Обеспечила полный переход на независимую работу (in-house finance) от аутсорсинга.
        - Успешный переезд склада.
        - Сохранение и мотивация сотрудников в сложный период.
        - Отличные показатели за годовой аудит.'
        ],
    [
        'title' => 'Finance Controller, Fragrance and Beauty',
        'company' => 'ООО "Шанель"',
        'city' => 'Москва',
        'website' => 'www.chanel.com',
        'datestart' => '02.2012',
        'datefinish' => '06.2016',
        'experience' => '- Budgeting and Reporting for division: Quarterly, Annual reporting, 4 budget cycles per year.
- Ensuring compliance to IFRS, making necessary adjustments in policies.
- Monitoring and controlling functions\' operational budgets with full support to function managers (commercial, marketing, other teams).
- Providing monthly financial reporting and analysis to functional management (plan-fact, fact-fact analysis).
- External Audit coordination.',
        'achievements' => '- Started as Finance Controller for Watches & Fine Jewellery division, but after 3 months was promoted to major f&b division.
- P&L by point of sale project provided in-depth analysis of the market, minimized information blanks in POS decision making.
- Automated Budget check project saved costs on finance and business people, purchase orders became obsolete.'
    ],
    [
        'title' => 'Marketing Finance Senior Analyst, Brands',
        'company' => 'British American Tobacco Russia',
        'city' => 'Москва',
        'website' => 'https://www.bat.com/',
        'datestart' => '09.2008',
        'datefinish' => '02.2012',
        'experience' => '- Preparing P&L by brand and consolidated. P&L reporting aligned with IFRS. Working in SAP, HFM, Cognos. Reporting key variances and providing commentaries.
- Preparing annual budgets with input from Marketing team. Comparing actual performance vs plan, discussing, consolidating information and providing commentaries.
- Activity appraisal and benchmarking.
- Brand financial evaluation, risk assessment.
- Stakeholder engagement - educating marketing managers on basic principles of finance, presenting financial information to non-finance teams.',
        'achievements' => ''
        // ' - Raising marketing awareness of finance processes helped eliminate mistakes in budgeting and minimize efforts of employees. Hence, saving on payroll and optimizing headcount.'
    ],
];

$education = [
    [
        'title' => 'Аналитик больших данных',
        'school' => 'Онлайн-платформа GeekBrains, gb.ru',
        'city' => 'Москва',
        'yearstart' => '2022',
        'yearfinish' => '',
        'comment' => 'Аналитик Big data. По программе Цифровые професии.'
        ],
    [
        'title' => 'Сертифицированный бухгалтер по управленческому учету',
        'school' => 'Chartered Institute of Management Accountants (CIMA)',
        'city' => 'London',
        'yearstart' => '2008',
        'yearfinish' => '2012',
        'comment' => ''
        ],
    [
        'title' => 'Магистр Экономики',
        'school' => 'Central European University (CEU)',
        'city' => 'Будапешт, Венгрия',
        'yearstart' => '08.2006',
        'yearfinish' => '06.2008',
        'comment' => 'Master of Arts in Economic. Обучение проходило полностью на английском языке.'
        ],
    [
        'title' => 'Инженер-специалист по информационным технологиям',
        'school' => 'Северный (Арктический) федеральный университет (САФУ)',
        'city' => 'Архангельск',
        'yearstart' => '09.2001',
        'yearfinish' => '06.2006',
        'comment' => ''
        ],
];
?>

<!DOCTYPE html>
<html>
  <head>
    <title>Мое резюме</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
    <link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Jost:wght@300&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <style>
    html,body,h1,h2,h3,h4,h5,h6 {font-family: 'Jost', sans-serif;}
    </style>
  </head>
<body class="w3-light-grey">

<!-- Page Container -->
<div class="w3-content w3-margin-top" style="max-width:1400px;">

  <!-- The Grid -->
  <div class="w3-row-padding">

    <!-- Left Column -->
    <div class="w3-third">

      <div class="w3-white w3-text-grey w3-card-4">
        <div class="w3-display-container">
          <img src="https://sun9-58.userapi.com/impg/7NRg91f8YCSafLAghRbUBo4ZDzKIB73mkbcOOw/q0jVoNpjcaI.jpg?size=810x1080&quality=95&sign=9dc177383e5b9ed16b047919c2ee106a&type=album" style="width:100%" alt="Avatar">
          <div class="w3-display-bottomleft w3-container w3-text-black">
            <h2 class="w3-teal"><?= $firstname, " ", $lastname;?></h2>
          </div>
        </div>
        <div class="w3-container">
          <p><i class="fa fa-briefcase fa-fw w3-margin-right w3-large w3-text-teal"></i><?=$occupation;?></p>
          <p><i class="fa fa-home fa-fw w3-margin-right w3-large w3-text-teal"></i><?=$city, ", ", $country;?></p>
          <p><i class="fa fa-envelope fa-fw w3-margin-right w3-large w3-text-teal"></i><?=$email?></p>
          <p><i class="fa fa-phone fa-fw w3-margin-right w3-large w3-text-teal"></i><?=$phone?></p>
          <hr>

          <p class="w3-large"><b><i class="fa fa-asterisk fa-fw w3-margin-right w3-text-teal"></i>Навыки</b></p>
          <?php for ($i1 = 0; $i1 < count($skills); $i1++) {
            $tempPercent = $skills[$i1]['percent'];
            ?>
            <p><?php echo $skills[$i1]['name'];?></p>
            <div class="w3-light-grey w3-round-xlarge w3-small">
              <div class="w3-container w3-center w3-round-xlarge w3-teal" style="width:<?php echo $tempPercent;?>%"><?php echo $tempPercent;?>%</div>
            </div>
            <?php }?>
          <br>

          <p class="w3-large w3-text-theme"><b><i class="fa fa-globe fa-fw w3-margin-right w3-text-teal"></i>Языки</b></p>
          <?php for ($i2 = 0; $i2 < count($languages); $i2++) {?>
            <p><?php echo $languages[$i2]['name'];?></p>
            <div class="w3-light-grey w3-round-xlarge">
              <div class="w3-round-xlarge w3-teal" style="height:24px;width:<?php echo $languages[$i2]['percent'];?>%"></div>
            </div>
            <?php }?>
          <br>
        </div>
      </div><br>

    <!-- End Left Column -->
    </div>

    <!-- Right Column -->
    <div class="w3-twothird">

      <div class="w3-container w3-card w3-white w3-margin-bottom">
        <h2 class="w3-text-grey w3-padding-16"><i class="fa fa-suitcase fa-fw w3-margin-right w3-xxlarge w3-text-teal"></i>Опыт работы</h2>
        <?php for ($i3 = 0; $i3 < count($jobExperience); $i3++) {?>
        <div class="w3-container">
          <h5 class="w3-opacity"><b><?= $jobExperience[$i3]['title'];?></b></h5>
          <h5 class="w3-opacity"><?= $jobExperience[$i3]['company'], ", ", $jobExperience[$i3]['city'];?></h5>
          <h5 class="w3-opacity"><b><?= $jobExperience[$i3]['website'];?></b></h5>
          <h6 class="w3-text-teal"><i class="fa fa-calendar fa-fw w3-margin-right"></i><?= date_format(date_create_from_format('m.Y',$jobExperience[$i3]['datestart']),'M Y');
          ?> -
          <?php if ($jobExperience[$i3]['datefinish'] == '') {?>
              <span class="w3-tag w3-teal w3-round">Current</span>
          <?php } else {
              echo date_format(date_create_from_format('m.Y',$jobExperience[$i3]['datefinish']),'M Y');
          }?>
          </h6>
          <p><?= nl2br($jobExperience[$i3]['experience']);?></p>
          <?php if ($jobExperience[$i3]['achievements'] != '') {?>
          <h5 class="w3-opacity">Достижения:</h5>
          <p><?= nl2br($jobExperience[$i3]['achievements']);?></p>
          <?php }
          if ($i3 != count($jobExperience) - 1) {
          ?>
          <hr>
          <?php }?>
          </div>
          <?php }?>
      </div>

      <div class="w3-container w3-card w3-white">
        <h2 class="w3-text-grey w3-padding-16"><i class="fa fa-certificate fa-fw w3-margin-right w3-xxlarge w3-text-teal"></i>Образование</h2>
        <?php for ($i4 = 0; $i4 < count($education); $i4++) {?>
        <div class="w3-container">
          <h5 class="w3-opacity"><b><?= $education[$i4]['school'], ', ', $education[$i4]['city'];?></b></h5>
          <h5 class="w3-opacity"><?= $education[$i4]['title'];?></h5>
          <h6 class="w3-text-teal"><i class="fa fa-calendar fa-fw w3-margin-right"></i><?= $education[$i4]['yearstart'];
          ?> -
          <?php if ($education[$i4]['yearfinish'] == '') {?>
              <span class="w3-tag w3-teal w3-round">Current</span>
          <?php } else {
              echo $education[$i4]['yearfinish'];
          }?></h6>
          <p><?= $education[$i4]['comment'];?></p>
          <hr>
        </div>
        <?php }?>
      </div>

    <!-- End Right Column -->
    </div>

  <!-- End Grid -->
  </div>

  <!-- End Page Container -->
</div>

<!-- Footer -->
<footer class="w3-container w3-teal w3-center w3-margin-top">
  <p>Find me on social media.</p>
  <i class="fa fa-pinterest-p w3-hover-opacity"></i>
  <i class="fa fa-twitter w3-hover-opacity"></i>
  <i class="fa fa-linkedin w3-hover-opacity"></i>
 <!-- End footer -->
 </footer>

</body>
</html>
