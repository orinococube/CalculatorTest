import React, { Component } from 'react';
import Calculator from './Calculator';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
        <Calculator />
      </div>
    );
  }
}
