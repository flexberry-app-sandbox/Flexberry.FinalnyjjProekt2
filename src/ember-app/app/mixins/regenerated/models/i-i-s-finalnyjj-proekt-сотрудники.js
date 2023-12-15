import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  имя: DS.attr('string'),
  кодСотру: DS.attr('number'),
  номерПас: DS.attr('number'),
  отчество: DS.attr('string'),
  серияПас: DS.attr('number'),
  фамилия: DS.attr('string'),
  должности: DS.belongsTo('i-i-s-finalnyjj-proekt-должности', { inverse: null, async: false }),
  отделы: DS.belongsTo('i-i-s-finalnyjj-proekt-отделы', { inverse: null, async: false })
});

export let ValidationRules = {
  имя: {
    descriptionKey: 'models.i-i-s-finalnyjj-proekt-сотрудники.validations.имя.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  кодСотру: {
    descriptionKey: 'models.i-i-s-finalnyjj-proekt-сотрудники.validations.кодСотру.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, integer: true }),
    ],
  },
  номерПас: {
    descriptionKey: 'models.i-i-s-finalnyjj-proekt-сотрудники.validations.номерПас.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  отчество: {
    descriptionKey: 'models.i-i-s-finalnyjj-proekt-сотрудники.validations.отчество.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  серияПас: {
    descriptionKey: 'models.i-i-s-finalnyjj-proekt-сотрудники.validations.серияПас.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  фамилия: {
    descriptionKey: 'models.i-i-s-finalnyjj-proekt-сотрудники.validations.фамилия.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  должности: {
    descriptionKey: 'models.i-i-s-finalnyjj-proekt-сотрудники.validations.должности.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  отделы: {
    descriptionKey: 'models.i-i-s-finalnyjj-proekt-сотрудники.validations.отделы.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('СотрудникиE', 'i-i-s-finalnyjj-proekt-сотрудники', {
    кодСотру: attr('Код сотрудника', { index: 0 }),
    фамилия: attr('Фамилия', { index: 1 }),
    имя: attr('Имя', { index: 2 }),
    отчество: attr('Отчество', { index: 3 }),
    серияПас: attr('Серия паспорта', { index: 4 }),
    номерПас: attr('Номер паспорта', { index: 5 }),
    отделы: belongsTo('i-i-s-finalnyjj-proekt-отделы', 'Отделы', {
      название: attr('Название', { index: 7, hidden: true })
    }, { index: 6, displayMemberPath: 'название' }),
    должности: belongsTo('i-i-s-finalnyjj-proekt-должности', 'Должности', {
      наименование: attr('Наименование', { index: 9, hidden: true })
    }, { index: 8, displayMemberPath: 'наименование' })
  });

  modelClass.defineProjection('СотрудникиL', 'i-i-s-finalnyjj-proekt-сотрудники', {
    кодСотру: attr('Код сотрудника', { index: 0 }),
    фамилия: attr('Фамилия', { index: 1 }),
    имя: attr('Имя', { index: 2 }),
    отчество: attr('Отчество', { index: 3 }),
    серияПас: attr('Серия паспорта', { index: 4 }),
    номерПас: attr('Номер паспорта', { index: 5 }),
    отделы: belongsTo('i-i-s-finalnyjj-proekt-отделы', 'Название', {
      название: attr('Название', { index: 6 })
    }, { index: -1, hidden: true }),
    должности: belongsTo('i-i-s-finalnyjj-proekt-должности', 'Наименование', {
      наименование: attr('Наименование', { index: 7 })
    }, { index: -1, hidden: true })
  });
};
