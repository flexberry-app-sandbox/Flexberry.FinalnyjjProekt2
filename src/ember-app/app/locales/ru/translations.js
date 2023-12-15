import $ from 'jquery';
import EmberFlexberryTranslations from 'ember-flexberry/locales/ru/translations';

import IISFinalnyjjProektГрафикиОтпускаLForm from './forms/i-i-s-finalnyjj-proekt-графики-отпуска-l';
import IISFinalnyjjProektДолжностиLForm from './forms/i-i-s-finalnyjj-proekt-должности-l';
import IISFinalnyjjProektОтделыLForm from './forms/i-i-s-finalnyjj-proekt-отделы-l';
import IISFinalnyjjProektРасчетныйЛистLForm from './forms/i-i-s-finalnyjj-proekt-расчетный-лист-l';
import IISFinalnyjjProektСогласиеНаОпдLForm from './forms/i-i-s-finalnyjj-proekt-согласие-на-опд-l';
import IISFinalnyjjProektСотрудникиLForm from './forms/i-i-s-finalnyjj-proekt-сотрудники-l';
import IISFinalnyjjProektГрафикиОтпускаEForm from './forms/i-i-s-finalnyjj-proekt-графики-отпуска-e';
import IISFinalnyjjProektДолжностиEForm from './forms/i-i-s-finalnyjj-proekt-должности-e';
import IISFinalnyjjProektОтделыEForm from './forms/i-i-s-finalnyjj-proekt-отделы-e';
import IISFinalnyjjProektРасчетныйЛистEForm from './forms/i-i-s-finalnyjj-proekt-расчетный-лист-e';
import IISFinalnyjjProektСогласиеНаОпдEForm from './forms/i-i-s-finalnyjj-proekt-согласие-на-опд-e';
import IISFinalnyjjProektСотрудникиEForm from './forms/i-i-s-finalnyjj-proekt-сотрудники-e';
import IISFinalnyjjProektГрафикиОтпускаModel from './models/i-i-s-finalnyjj-proekt-графики-отпуска';
import IISFinalnyjjProektДолжностиModel from './models/i-i-s-finalnyjj-proekt-должности';
import IISFinalnyjjProektОтделыModel from './models/i-i-s-finalnyjj-proekt-отделы';
import IISFinalnyjjProektРасчетныйЛистModel from './models/i-i-s-finalnyjj-proekt-расчетный-лист';
import IISFinalnyjjProektСогласиеНаОпдModel from './models/i-i-s-finalnyjj-proekt-согласие-на-опд';
import IISFinalnyjjProektСоставРасчетаModel from './models/i-i-s-finalnyjj-proekt-состав-расчета';
import IISFinalnyjjProektСотрудникиModel from './models/i-i-s-finalnyjj-proekt-сотрудники';

const translations = {};
$.extend(true, translations, EmberFlexberryTranslations);

$.extend(true, translations, {
  models: {
    'i-i-s-finalnyjj-proekt-графики-отпуска': IISFinalnyjjProektГрафикиОтпускаModel,
    'i-i-s-finalnyjj-proekt-должности': IISFinalnyjjProektДолжностиModel,
    'i-i-s-finalnyjj-proekt-отделы': IISFinalnyjjProektОтделыModel,
    'i-i-s-finalnyjj-proekt-расчетный-лист': IISFinalnyjjProektРасчетныйЛистModel,
    'i-i-s-finalnyjj-proekt-согласие-на-опд': IISFinalnyjjProektСогласиеНаОпдModel,
    'i-i-s-finalnyjj-proekt-состав-расчета': IISFinalnyjjProektСоставРасчетаModel,
    'i-i-s-finalnyjj-proekt-сотрудники': IISFinalnyjjProektСотрудникиModel
  },

  'application-name': 'Модуль кадрового электронного документооборота',

  forms: {
    loading: {
      'spinner-caption': 'Данные загружаются, пожалуйста подождите...'
    },
    index: {
      greeting: 'Добро пожаловать на тестовый стенд ember-flexberry!'
    },

    application: {
      header: {
        menu: {
          'sitemap-button': {
            title: 'Меню'
          },
          'user-settings-service-checkbox': {
            caption: 'Использовать сервис сохранения пользовательских настроек'
          },
          'show-menu': {
            caption: 'Показать меню'
          },
          'hide-menu': {
            caption: 'Скрыть меню'
          },
          'language-dropdown': {
            caption: 'Язык приложения',
            placeholder: 'Выберите язык'
          }
        },
        login: {
          caption: 'Вход'
        },
        logout: {
          caption: 'Выход'
        }
      },

      footer: {
        'application-name': 'Модуль кадрового электронного документооборота',
        'application-version': {
          caption: 'Версия аддона {{version}}',
          title: 'Это версия аддона ember-flexberry, которая сейчас используется в этом тестовом приложении ' +
          '(версия npm-пакета + хэш коммита). ' +
          'Кликните, чтобы перейти на GitHub.'
        }
      },

      sitemap: {
        'application-name': {
          caption: 'Модуль кадрового электронного документооборота',
          title: 'Finalnyjj proekt'
        },
        'application-version': {
          caption: 'Версия аддона {{version}}',
          title: 'Это версия аддона ember-flexberry, которая сейчас используется в этом тестовом приложении ' +
          '(версия npm-пакета + хэш коммита). ' +
          'Кликните, чтобы перейти на GitHub.'
        },
        index: {
          caption: 'Главная',
          title: ''
        },
        'кадровые-документы': {
          caption: 'Кадровые документы',
          title: 'Кадровые документы',
          'i-i-s-finalnyjj-proekt-расчетный-лист-l': {
            caption: 'Расчетный лист',
            title: ''
          },
          'i-i-s-finalnyjj-proekt-согласие-на-опд-l': {
            caption: 'Согласие на опд',
            title: ''
          },
          'i-i-s-finalnyjj-proekt-должности-l': {
            caption: 'Должности',
            title: ''
          },
          'i-i-s-finalnyjj-proekt-сотрудники-l': {
            caption: 'Сотрудники',
            title: ''
          },
          'i-i-s-finalnyjj-proekt-отделы-l': {
            caption: 'Отделы',
            title: ''
          },
          'i-i-s-finalnyjj-proekt-графики-отпуска-l': {
            caption: 'Графики отпуска',
            title: ''
          }
        }
      }
    },

    'edit-form': {
      'save-success-message-caption': 'Сохранение завершилось успешно',
      'save-success-message': 'Объект сохранен',
      'save-error-message-caption': 'Ошибка сохранения',
      'delete-success-message-caption': 'Удаление завершилось успешно',
      'delete-success-message': 'Объект удален',
      'delete-error-message-caption': 'Ошибка удаления'
    },
    'i-i-s-finalnyjj-proekt-графики-отпуска-l': IISFinalnyjjProektГрафикиОтпускаLForm,
    'i-i-s-finalnyjj-proekt-должности-l': IISFinalnyjjProektДолжностиLForm,
    'i-i-s-finalnyjj-proekt-отделы-l': IISFinalnyjjProektОтделыLForm,
    'i-i-s-finalnyjj-proekt-расчетный-лист-l': IISFinalnyjjProektРасчетныйЛистLForm,
    'i-i-s-finalnyjj-proekt-согласие-на-опд-l': IISFinalnyjjProektСогласиеНаОпдLForm,
    'i-i-s-finalnyjj-proekt-сотрудники-l': IISFinalnyjjProektСотрудникиLForm,
    'i-i-s-finalnyjj-proekt-графики-отпуска-e': IISFinalnyjjProektГрафикиОтпускаEForm,
    'i-i-s-finalnyjj-proekt-должности-e': IISFinalnyjjProektДолжностиEForm,
    'i-i-s-finalnyjj-proekt-отделы-e': IISFinalnyjjProektОтделыEForm,
    'i-i-s-finalnyjj-proekt-расчетный-лист-e': IISFinalnyjjProektРасчетныйЛистEForm,
    'i-i-s-finalnyjj-proekt-согласие-на-опд-e': IISFinalnyjjProektСогласиеНаОпдEForm,
    'i-i-s-finalnyjj-proekt-сотрудники-e': IISFinalnyjjProektСотрудникиEForm
  },

});

export default translations;
