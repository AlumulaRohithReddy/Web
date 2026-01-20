import { TestBed } from '@angular/core/testing';

import { Calserve } from './calserve';

describe('Calserve', () => {
  let service: Calserve;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(Calserve);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
