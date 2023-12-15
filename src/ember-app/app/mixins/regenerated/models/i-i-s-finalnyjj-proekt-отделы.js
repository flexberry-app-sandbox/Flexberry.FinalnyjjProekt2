import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  кодОтдела: DS.attr('number'),
  название: DS.attr('string')
});

export let ValidationRules = {
  кодОтдела: {
    descriptionKey: 'models.i-i-s-finalnyjj-proekt-отделы.validations.кодОтдела.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, integer: true }),
    ],
  },
  название: {
    descriptionKey: 'models.i-i-s-finalnyjj-proekt-отделы.validations.название.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ОтделыE', 'i-i-s-finalnyjj-proekt-отделы', {
    кодОтдела: attr('Код отдела', { index: 0 }),
    название: attr('Название', { index: 1 })
  });

  modelClass.defineProjection('ОтделыL', 'i-i-s-finalnyjj-proekt-отделы', {
    кодОтдела: attr('Код отдела', { index: 0 }),
    название: attr('Название', { index: 1 })
  });
};
